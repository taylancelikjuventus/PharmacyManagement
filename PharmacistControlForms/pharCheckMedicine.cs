using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistControlForms
{
    public partial class pharCheckMedicine : UserControl
    {
        public pharCheckMedicine()
        {
            InitializeComponent();
        }

        /******DB functions****************/
        DBfunc dbase = new DBfunc();
        string query;


        //if btnsearch is clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(comboBoxCheck.SelectedIndex != -1)
            {



                if (comboBoxCheck.Text == "View Valid Medicines")
                {
                    try
                    {
                        //valid
                        query = "select * from Medicine WHERE medexpdate >= getDate()";
                        DataSet DS = dbase.getData(query);
                        if(DS.Tables[0].Rows.Count != 0)
                        {
                            guna2DataGridView1.DataSource = DS.Tables[0];
                            labelHeader.Text = "Valid Medicines";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //clearFormFields();
                    }

                }
                if (comboBoxCheck.Text == "View Expired Medicines")
                {
                   
                    try
                    {
                        //expired
                        query = "select * from Medicine WHERE medexpdate < getDate()";
                        DataSet DS = dbase.getData(query);
                        if (DS.Tables[0].Rows.Count != 0)
                        {
                            guna2DataGridView1.DataSource = DS.Tables[0];
                            labelHeader.Text = "Expired Medicines";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //clearFormFields();
                    }


                }

                if (comboBoxCheck.Text == "View All Medicines")
                {
                    try
                    {
                        //all
                        query = "select * from Medicine ";
                        DataSet DS = dbase.getData(query);
                        if (DS.Tables[0].Rows.Count != 0)
                        {
                            guna2DataGridView1.DataSource = DS.Tables[0];
                            labelHeader.Text = "All Medicines";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //clearFormFields();
                    }

                }
            }
            else
            {
                MessageBox.Show("No selection provided !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    
    
    
    
    
    }
}
