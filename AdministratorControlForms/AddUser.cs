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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        /******DB functions****************/
        DBfunc dbase = new DBfunc();
        string query;

        /*******functions**********/
        public void clearFormFields()
        {
            comboAddUserRole.SelectedIndex = -1;
            txtAddNAme.Clear();
            datepickerAddDOB.ResetText();
            txtAddUserId.Clear();
            txtAddUsername.Clear();
            txtAddEmail.Clear();
            txtAddPassword.Clear();
            pictureBoxUserID.ImageLocation = "";
            pictureBoxYesNo.ImageLocation = "";

        }


        /**********if from is loaded***********/
        private void AddUser_Load(object sender, EventArgs e)
        {
            //set location to panel2 of Administrator's location
            this.Location = new Point(316,65);
        }

        /*******If sign up is clicked***********/
        private void btnAddSignUp_Click(object sender, EventArgs e)
        {

            if (
                 comboAddUserRole.SelectedIndex == -1 &&
                 txtAddNAme.Text == "" &&
                 txtAddUserId.Text == "" &&
                 txtAddEmail.Text == "" && 
                 txtAddUsername.Text == "" &&
                 txtAddPassword.Text == "" 
                )
            {

                MessageBox.Show(this,"Fill all form fields ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearFormFields();

            }
            else {

                try
                {
                    query = "insert into users(userRole,fname,dob,userid,email,username,pass) " +
                        "values('" + comboAddUserRole.Text + "','" + txtAddNAme.Text + "','" + datepickerAddDOB.Text + "'," + Int64.Parse(txtAddUserId.Text) + ",'" + txtAddEmail.Text + "','" + txtAddUsername.Text + "','" + txtAddPassword.Text + "')";
                    dbase.setData(query, "Sign Up Successfull,row inserted...");
                    clearFormFields();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearFormFields();
                }

            }



        }

        /******if Clear button is clicked*******/
        private void btnAddClear_Click(object sender, EventArgs e)
        {

            clearFormFields();
        }

        //if username's text is changed check username's validity
        private void txtAddUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //username must be unique
                query = "select * from users where username='" + txtAddUsername.Text + "'";
                DataSet DS = dbase.getData(query);

                if (DS.Tables[0].Rows.Count != 0)
                {
                    pictureBoxYesNo.Image = Image.FromFile(@"D:\CurrentProjects\C#Projects\PharmacyManagementSystem\Pharmacy Management System in C#\no.png");
                }
                else
                {
                    pictureBoxYesNo.Image = Image.FromFile(@"D:\CurrentProjects\C#Projects\PharmacyManagementSystem\Pharmacy Management System in C#\yes.png");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /*************If user ID's text changed***********/
        private void txtAddUserId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //textfield boşken hata almamak için sadece yazıldıgında kontrol ediyoruz
                if (txtAddUserId.Text != "")
                {
                    //userID must be unique
                    query = "select * from users where userid=" + Int64.Parse(txtAddUserId.Text) + "";
                    DataSet DS = dbase.getData(query);

                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        pictureBoxUserID.Image = Image.FromFile(@"D:\CurrentProjects\C#Projects\PharmacyManagementSystem\Pharmacy Management System in C#\no.png");
                    }
                    else
                    {
                        pictureBoxUserID.Image = Image.FromFile(@"D:\CurrentProjects\C#Projects\PharmacyManagementSystem\Pharmacy Management System in C#\yes.png");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
