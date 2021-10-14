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
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        /******DB functions****************/
        DBfunc dbase = new DBfunc();
        string query;

        /*******if form is loaded**********/
        private void ViewUser_Load(object sender, EventArgs e)
        {
            //set location to panel2 of Administrator's location
            this.Location = new Point(316, 65);

            try
            {
                //load all users to table
                query = "select * from users ;";
                DataSet DS = dbase.getData(query);
                guna2DataGridViewView.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       

        /******filter table by text entered on username textfield***********/
        private void txtViewName_TextChanged(object sender, EventArgs e)
        {
            if(txtViewName.Text != "")
            {
                try
                {
                    //load all users to table
                    query = "select * from users WHERE username LIKE '"+txtViewName.Text+"%'";
                    DataSet DS = dbase.getData(query);
                    //if table is not null
                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        guna2DataGridViewView.DataSource = DS.Tables[0];
                    }
                    else
                    {
                        guna2DataGridViewView.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }


        string username;
        /********* if any cell of table is clicked*************/
        private void guna2DataGridViewView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get username of clicked row
            try //try attık çünkü tablo boşken de kullanıcı tıklayabilir
            {
                //we get username by selecting row of clicked cell and coulun index 6 this clicked
                //row which is username
                username = guna2DataGridViewView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnViewDelete_Click(object sender, EventArgs e)
        {
            txtViewName.Clear();
            try 
            {
                //we cannot delete our own account
                if (username != Form1.currentUsername)
                {
                    if (MessageBox.Show(this, "Are you sure to delete this user ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)  == DialogResult.Yes)
                    {
                        query = "delete from users WHERE username = '" + username + "'";
                        dbase.setData(query, "row deleted ...");
                        btnViewRefresh_Click(this, null);
                    }

                }
                else
                {
                    MessageBox.Show("You cannot delete your own account !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnViewRefresh_Click(this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //if btn refresh is clicked
        private void btnViewRefresh_Click(object sender, EventArgs e)
        {
            txtViewName.Clear();
            ViewUser_Load(this, null);
        }
    }
}
