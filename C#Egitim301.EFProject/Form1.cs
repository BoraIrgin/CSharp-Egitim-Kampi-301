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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDBEntities db = new EgitimKampiEFTravelDBEntities();
        private void btnList_Click(object sender, EventArgs e)
        {         
            var values = db.Guides.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {  
            Guide newGuide = new Guide();
            newGuide.GuideName = txtName.Text;
            newGuide.GuideSurname = txtSurname.Text;
            db.Guides.Add(newGuide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Guide guideToDelete = db.Guides.Find(id);
            if (guideToDelete != null)
            {
                db.Guides.Remove(guideToDelete);
                db.SaveChanges();
                MessageBox.Show("Rehber Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Guide guideToUpdate = db.Guides.Find(id);
            if (guideToUpdate != null)
            {
                guideToUpdate.GuideName = txtName.Text;
                guideToUpdate.GuideSurname = txtSurname.Text;
                db.SaveChanges();
                MessageBox.Show("Rehber Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var values = db.Guides.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
