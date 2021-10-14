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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**********DB functions*********/
        DBfunc dbase = new DBfunc();
        string query;


        /*************To pass username and pass to Administrator form************/
        public static string currentUsername;
        public static string currentPassword;

        /***********if exit icon is clicked**************/
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /***********if clear is clicked******/
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtLoginPassword.Clear();
            txtLoginUsename.Clear();
        }


        /************if signin is clicked *****/
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtLoginUsename.Text != "" && txtLoginPassword.Text != "")
            {
                //1.For test purpose 
                if(txtLoginUsename.Text == "adm" && txtLoginPassword.Text == "adm")
                {
                    //store username and pass for Administrator form
                    //so that we can show user name on Admin dashboard
                    currentUsername = txtLoginUsename.Text.Trim();
                    currentPassword = txtLoginPassword.Text.Trim();

                    //open AdminDashboard
                    Administrator a = new Administrator();
                    a.Show();
                    this.Hide();

                }

                if (txtLoginUsename.Text == "phar" && txtLoginPassword.Text == "phar")
                {
                    
                    currentUsername = txtLoginUsename.Text.Trim();
                    currentPassword = txtLoginPassword.Text.Trim();

                    //open pharmcist's Dashboard
                    Pharmacist p = new Pharmacist();
                    p.Show();
                    this.Hide();

                }

                //2.validating from database
                query = "select * from users WHERE username='"+txtLoginUsename.Text+"' AND pass='"+txtLoginPassword.Text+"'";
                DataSet DS = dbase.getData(query);
                
                //if user is an admin
                if(DS.Tables[0].Rows.Count != 0 && DS.Tables[0].Rows[0][1].ToString() == "Administrator")
                {
                    //store username and pass for Administrator form
                    //so that we can show user name on Admin dashboard
                    currentUsername = txtLoginUsename.Text.Trim();
                    currentPassword = txtLoginPassword.Text.Trim();

                    //open AdminDashboard
                    Administrator a = new Administrator();
                    a.Show();
                    this.Hide();
                }
                else if (DS.Tables[0].Rows.Count != 0 && DS.Tables[0].Rows[0][1].ToString() == "Pharmacist")
                {
                    //open PArmacist's dashboard
                    currentUsername = txtLoginUsename.Text.Trim();
                    currentPassword = txtLoginPassword.Text.Trim();

                    //open AdminDashboard
                    Pharmacist p = new Pharmacist();
                    p.Show();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show(this, "Wrong username or password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
            else 
            { 
                MessageBox.Show(this, "Please enter username and password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }





}
}
