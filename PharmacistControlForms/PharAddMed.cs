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
    public partial class PharAddMed : UserControl
    {
        public PharAddMed()
        {
            InitializeComponent();
        }

        /******DB functions****************/
        DBfunc dbase = new DBfunc();
        string query;

        private void clearFormFields()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            txtMedNumber.Clear();
            guna2DateTimePickerManufacture.ResetText();
            guna2DateTimePickerExpire.ResetText();
            txtPricePerUnit.Clear();
            txtQty.Clear();
            pictureBoxYesNo.Image = null;

        }


        /*****if Add is Clicked********/
        private void btnPharViewRefresh_Click(object sender, EventArgs e)
        {

            if (
                txtMedID.Text !="" &&
                txtMedName.Text != "" &&  
                txtMedNumber.Text != "" &&
                txtPricePerUnit.Text != "" && 
                txtQty.Text != ""  

                   ) {
                try
                {
                    //check if medicine ID is unique
                    query = "select * from medicine WHERE medid='"+txtMedID.Text+"'";
                    DataSet DS = dbase.getData(query);
                    if(DS.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("This medical ID already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else {
                        query = "insert into medicine VALUES('" + txtMedID.Text + "','" + txtMedName.Text + "','" + txtMedNumber.Text + "','" + guna2DateTimePickerManufacture.Text + "','" + guna2DateTimePickerExpire.Text + "'," + Int64.Parse(txtQty.Text) + "," + Int64.Parse(txtPricePerUnit.Text) + ")";
                        dbase.setData(query, "row inserted ...");
                        clearFormFields();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearFormFields();
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //clearFormFields();
            }
        }

        /**********if text changed******/
        private void txtMedID_TextChanged(object sender, EventArgs e)
        {
            if(txtMedID.Text != "") {


                try
                {
                    //check if medicine ID is unique
                    query = "select * from medicine WHERE medid ='" + txtMedID.Text + "'";
                    DataSet DS = dbase.getData(query);
                    
                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        pictureBoxYesNo.ImageLocation = @"D:\CurrentProjects\C#Projects\PharmacyManagementSystem\Pharmacy Management System in C#\no.png";
                    }
                    else
                    {
                        pictureBoxYesNo.ImageLocation = @"D:\CurrentProjects\C#Projects\PharmacyManagementSystem\Pharmacy Management System in C#\yes.png";

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearFormFields();
                }


            }
            else
            {
                pictureBoxYesNo.Image = null;
            }


        }

        /********if clear is clicked**********/
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clearFormFields();
        }
    }
}
