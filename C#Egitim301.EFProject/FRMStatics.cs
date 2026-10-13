using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Egitim301.EFProject
{
    public partial class FRMStatics : Form
    {
        public FRMStatics()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDBEntities db = new EgitimKampiEFTravelDBEntities();
        private void FRMStatics_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Locations.Count().ToString();
            lblSumCapacity.Text = db.Locations.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Guides.Count().ToString();
            lblAvgCapacity.Text = db.Locations.Average(x => x.LocationCapacity).ToString();
            lblAvgLocationPrice.Text = ((float)db.Locations.Average(x => x.LocationPrice)).ToString("f2") + " TL";
            int lastcountryid = db.Locations.Max(x => x.LocationID);
            lblLastCountry.Text = db.Locations.Where(x => x.LocationID == lastcountryid).Select(y => y.LocationCountry).FirstOrDefault();
            lblKapadokyaLocationCapacity.Text = db.Locations.Where(x => x.LocationCity == "Kapadokya").Sum(y => y.LocationCapacity).ToString();
            lblTrAvgCapacity.Text = db.Locations.Where(x => x.LocationCountry == "Türkiye").Average(y => y.LocationCapacity).ToString();
            lblRomaTravelGudieName.Text = db.Locations.Where(x => x.LocationCity == "Roma").Select(y => y.Guide.GuideName + " " + y.Guide.GuideSurname).FirstOrDefault();
            lblBiggestTourCapacityCityAndCountry.Text = db.Locations.Where(x => x.LocationCapacity == db.Locations.Max(y => y.LocationCapacity)).Select(z => z.LocationCity + " / " + z.LocationCountry).FirstOrDefault();
            lblMaxPriceTourNameCityCountryPrice.Text = db.Locations.Where(x => x.LocationPrice == db.Locations.Max(y => y.LocationPrice)).Select(z => z.LocationCity + " / " + z.LocationCountry + " / " + z.LocationPrice).FirstOrDefault();
            lblGulserenIrginLocationCount.Text = db.Locations.Where(x => x.Guide.GuideName == "Gülseren" && x.Guide.GuideSurname == "İrgin").Count().ToString();
        }
    }
}