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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        /******DB functions****************/
        DBfunc dbase = new DBfunc();
        string query;

        /************IF From is loaded**************/
        private void Profile_Load(object sender, EventArgs e)
        {
            //set location to panel2 of Administrator's location
            this.Location = new Point(316,65);

            //show username on left side
            labelProfShowUser.Text = Form1.currentUsername;

            try
            {
                query = "select * from users where username='" + labelProfShowUser.Text.Trim() + "'";
                DataSet DS = dbase.getData(query);

                //fill from with retrived data
                comboProfUserRole.Items.Add("Administrator");
                comboProfUserRole.Items.Add("Pharmacist");
                comboProfUserRole.SelectedItem = DS.Tables[0].Rows[0][1].ToString();
                txtProfName.Text = DS.Tables[0].Rows[0][2].ToString();
                txtProfPassword.Text = DS.Tables[0].Rows[0][7].ToString();
                datepickerProfDOB.Text = DS.Tables[0].Rows[0][3].ToString();
                txtProfEmail.Text = DS.Tables[0].Rows[0][5].ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clearFormFields();
            }



        }

        /*********if update is clicked********/
        private void btnProfSignUp_Click(object sender, EventArgs e)
        {

            try
            {
                if (
                    txtProfName.Text != "" ||
                    txtProfPassword.Text != "" ||
                    comboProfUserRole.SelectedIndex != -1
                    ) {

                    query = "update users set userRole='" + comboProfUserRole.Text + "',fname='" + txtProfName.Text + "',pass='" + txtProfPassword.Text + "',dob='" + datepickerProfDOB.Text + "',email='" + txtProfEmail.Text + "' WHERE username='"+labelProfShowUser.Text+"'";
                    dbase.setData(query, "Updated...");

                    //reload form
                    Profile_Load(this, null);
                }
                else
                {
              MessageBox.Show("UserRole,Name,Password cannot to be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clearFormFields();
            }


        }

        private void btnProfClear_Click(object sender, EventArgs e)
        {
            Profile_Load(this, null);
        }
    }
}
