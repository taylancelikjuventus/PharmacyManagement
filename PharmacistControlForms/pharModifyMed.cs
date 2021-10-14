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
    public partial class pharModifyMed : UserControl
    {
        public pharModifyMed()
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
            txtAddQty.Text = "0";
            txtAvailQty.Clear();
            txtPricePerUnit.Clear();
        }


        /*******if Clear is clicked**********/
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFormFields();
        }


        /******if search clicked*****/
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtMedID.Text != "")
            {

                try
                {
                    //check if medicine ID is unique
                    query = "select * from medicine WHERE medid ='" + txtMedID.Text + "'";
                    DataSet DS = dbase.getData(query);

                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        txtMedName.Text = DS.Tables[0].Rows[0][2].ToString();
                        txtMedNumber.Text = DS.Tables[0].Rows[0][3].ToString();
                        guna2DateTimePickerManufacture.Text = DS.Tables[0].Rows[0][4].ToString();
                        guna2DateTimePickerExpire.Text = DS.Tables[0].Rows[0][5].ToString();
                        txtAvailQty.Text = DS.Tables[0].Rows[0][6].ToString();
                        txtPricePerUnit.Text = DS.Tables[0].Rows[0][7].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No such a medicine found !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clearFormFields();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearFormFields();
                }


            }
            

        }


        /***********if Update is clicked****/
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                //check if medicine ID is unique
                query = "select * from medicine WHERE medid ='" + txtMedID.Text + "'";
                DataSet DS = dbase.getData(query);

                //UPDATE HERE
                if (DS.Tables[0].Rows.Count != 0)
                {
                    Int64 totalqty = Int64.Parse(txtAvailQty.Text) + Int64.Parse(txtAddQty.Text);

                    query = "update medicine set medid='"+txtMedID.Text+"',medname='"+txtMedName.Text+"',mednumber='"+txtMedNumber.Text+"',medmandate='"+guna2DateTimePickerManufacture.Text+"',medexpdate='"+guna2DateTimePickerExpire.Text+"',medqty="+totalqty+ ",medprice="+Int64.Parse(txtPricePerUnit.Text)+" WHERE medid='"+txtMedID.Text+"'";
                    dbase.setData(query, "Row is Updated ...");

                    clearFormFields();
                }
                else
                {
                    MessageBox.Show("No such a medicine found !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearFormFields();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clearFormFields();
            }


        }
    }
}
