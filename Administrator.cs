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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        /************Control Forms*************/
        private AdministratorControlForms.AdminDashboard dashboard = null;
        private AdministratorControlForms.AddUser adduser = null;
        private AdministratorControlForms.ViewUser viewuser = null;
        private AdministratorControlForms.Profile profile = null;


        /**********if exit icon is clicked*******/
        private void guna2Button5_Click(object sender, EventArgs e)
        {
         //Close all control froms first
            if (adduser != null)
                adduser.Close();
            if (dashboard != null)
                dashboard.Close();
            if (viewuser != null)
                viewuser.Close();
            if (profile != null)
                profile.Close();

            this.Close();
            //show login from
            Application.Restart(); //this opens up Login Form again
        }

      

        /**********IF form is loaded***************/
        private void Administrator_Load(object sender, EventArgs e)
        {
            //set username on label at bottom
            labeladminShowUser.Text =  Form1.currentUsername;

            //create all forms
            dashboard = new AdministratorControlForms.AdminDashboard();
            dashboard.Hide();
            

            adduser = new AdministratorControlForms.AddUser();
            adduser.Hide();
            viewuser = new AdministratorControlForms.ViewUser();
            viewuser.Hide();
            profile = new AdministratorControlForms.Profile();
            profile.Hide();
         }

         

        /********if profile button is clicked************/
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            profile.Select(); 
            profile.Show();
             

            viewuser.Hide();
            adduser.Hide();
            dashboard.Hide();

        }


       
        /**********IF AddUser is Clicked********/
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            adduser.Select();
            adduser.Show();

            viewuser.Hide();
            dashboard.Hide();
            profile.Hide();
        }

        /**********if dashboard button is clicked************/
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dashboard.Select();
            dashboard.Show();

            viewuser.Hide();
            adduser.Hide();
            profile.Hide();

        }

        /**********if viewuser button is clicked*******/
        private void guna2Button3_Click(object sender, EventArgs e)
        {

            viewuser.Select();
            viewuser.Show();

            dashboard.Hide();
            adduser.Hide();
            profile.Hide();
        }
    }
}
