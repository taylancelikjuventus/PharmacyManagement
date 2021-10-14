using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        /*************if Logout is clicked*************/
        private void btnPharLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        /***********if dashboad clicked********/
        private void btnPharDashboard_Click(object sender, EventArgs e)
        {
            pharDashboard1.Visible = true;
            pharDashboard1.BringToFront();

        }


        /**********if this form is loaded********/
        private void Pharmacist_Load(object sender, EventArgs e)
        {
            //make PharDashboard false
            pharDashboard1.Visible = false;
            pharAddMed1.Visible = false;
            pharViewMedicine1.Visible = false;
            pharCheckMedicine1.Visible = false;
            sellMEdicine1.Visible = false;
            pharModifyMed1.Visible = false;

            //click on dashboard button inside this program
            //btnPharDashboard_Click(this, null); //this doesn't change bg color of button
            btnPharDashboard.PerformClick();

        }

       

        private void btnPharViewMedicine_Click(object sender, EventArgs e)
        {
            //make it visible
            pharViewMedicine1.Visible = true;
            //pharAddMedicine1.Select(); this doesn't change z order of forms
            pharViewMedicine1.BringToFront();
        }

      

        private void btnPharCheckMedicine_Click(object sender, EventArgs e)
        {

            pharCheckMedicine1.Visible = true;
            pharCheckMedicine1.BringToFront();
        }

        private void btnPharSellMedicine_Click(object sender, EventArgs e)
        {
            sellMEdicine1.Visible = true;
            sellMEdicine1.BringToFront();
        }

        private void btnPharAddMEdicine_Click(object sender, EventArgs e)
        {
            pharAddMed1.Visible = true;
            pharAddMed1.BringToFront();
        }

        private void btnPharModifyMedicine_Click(object sender, EventArgs e)
        {
            pharModifyMed1.Visible = true;
            pharModifyMed1.BringToFront();
        }
    }
}
