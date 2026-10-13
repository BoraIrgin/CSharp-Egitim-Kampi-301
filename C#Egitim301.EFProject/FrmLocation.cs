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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDBEntities db = new EgitimKampiEFTravelDBEntities();
        Location location = new Location();
        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guides.Select(x=> new
            {
                
                FullName = x.GuideName + " " + x.GuideSurname,
                GuideId = x.GuideId
            }).ToList();
            
            comboBox1.DisplayMember = "FullName";
            comboBox1.DataSource = values;
            comboBox1.ValueMember = "GuideId";
        }
        

        private void btnList_Click(object sender, EventArgs e)
        {
            var locations = db.Locations.ToList();
            dataGridView1.DataSource = locations;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            location.LocationCity = txtCity.Text;
            location.LocationCountry = txtCountry.Text;
            location.LocationCapacity = byte.Parse(numericUpDown1.Text);
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.LocationDayNight = txtDayNight.Text;
            location.GuideId = int.Parse(comboBox1.SelectedValue.ToString());
            db.Locations.Add(location);
            db.SaveChanges();
            MessageBox.Show("Location Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var deletedValue = db.Locations.Find(id);
            db.Locations.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Location Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var updateValue = db.Locations.Find(id);
            updateValue.LocationCity = txtCity.Text;
            updateValue.LocationCountry = txtCountry.Text;
            updateValue.LocationCapacity = byte.Parse(numericUpDown1.Text);
            updateValue.LocationPrice = decimal.Parse(txtPrice.Text);
            updateValue.LocationDayNight = txtDayNight.Text;
            updateValue.GuideId = int.Parse(comboBox1.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Location Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var values = db.Locations.Where(x => x.LocationID == id).ToList();
            dataGridView1.DataSource = values;

            if (values.Count == 0)
            {
                MessageBox.Show("Location Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
