using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdministratorControlForms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        /******DB functions****************/
        DBfunc dbase = new DBfunc();
        string query;

        /*********If this from loaded************/
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //set location to panel2 of Administrator's location
            this.Location = new Point(316,65);

            //show number of admins and pharmacists
            query = "select count(*) from users WHERE userRole='Administrator'";
            DataSet DS = dbase.getData(query);

            int NoOfadmin =int.Parse(DS.Tables[0].Rows[0][0].ToString());
            labelDashNoOFAdmins.Text = NoOfadmin.ToString();

            query = "select count(*) from users WHERE userRole='Pharmacist'";
            DataSet DS2 = dbase.getData(query);
            labelDashNoOfPharmacists.Text = DS2.Tables[0].Rows[0][0].ToString();

        }

        private void btnDashRefresh_Click(object sender, EventArgs e)
        {
            //reload this form
            AdminDashboard_Load(this, null);
        }
    }
}
