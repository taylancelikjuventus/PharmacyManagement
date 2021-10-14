using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PharmacyManagementSystem.PharmacistControlForms
{
    public partial class SellMEdicine : UserControl
    {
        public SellMEdicine()
        {
            InitializeComponent();
        }

        /******DB functions****************/
        DBfunc dbase = new DBfunc();
        string query;

        private void SellMEdicine_Load(object sender, EventArgs e)
        {
            
                try
                {
                    //all valid medicines!
                    query = "select medname from Medicine WHERE medexpdate > getDate()";
                    DataSet DS = dbase.getData(query);
                  
                    for(int i = 0; i<DS.Tables[0].Rows.Count; i++)
                    {
                          listBox1.Items.Add(DS.Tables[0].Rows[i][0]);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearFormFields();
                }


            Console.WriteLine("NO OF ROWS = " +guna2DataGridView1.Rows.Count);

            
        }

        /**********if text is changed***********/
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                try
                {
                    //all valid medicines !
                    query = "select medname from Medicine WHERE medexpdate > getDate() AND medname LIKE '" + txtSearch.Text + "%'";
                    DataSet DS = dbase.getData(query);

                    if (DS.Tables[0].Rows.Count != 0) { 
                        listBox1.Items.Clear();
                        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        {
                        listBox1.Items.Add(DS.Tables[0].Rows[i][0]);
                        }
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
                listBox1.Items.Clear();
                //reload Form
                SellMEdicine_Load(this, null);
            }

        }

        string selected = "";
        /*******if selected index is changed*******/
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(listBox1.SelectedIndex != -1)
                selected = listBox1.SelectedItem.ToString();

                try
                {

                    //all
                    query = "select * from medicine WHERE medname = '" + selected + "'";
                    DataSet DS = dbase.getData(query);

                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        txtMedID.Text = DS.Tables[0].Rows[0][1].ToString();
                        txtMedName.Text = DS.Tables[0].Rows[0][2].ToString();
                        guna2DateTimePickerExpire.Text = DS.Tables[0].Rows[0][5].ToString();
                        txtPricePerUnit.Text = DS.Tables[0].Rows[0][7].ToString();

                        //calculate total price
                        int totalPrice = int.Parse(txtPricePerUnit.Text) * int.Parse(txtNoOfUnits.Text);

                        txtTotalPrice.Text = totalPrice.ToString();


                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearFormFields();
                }

            
        }


        int val = 0;
        protected Int64 qty,newqty;
        /**************if add to chart is clicked******/
        private void btnAddToChart_Click(object sender, EventArgs e)
        {
            if (txtMedID.Text != "")
            {
                try
                {
                    //Check out Stock
                    query = "select medQty from medicine where medid='" + txtMedID.Text + "'";
                    DataSet DS = dbase.getData(query);

                    qty = Int64.Parse( DS.Tables[0].Rows[0][0].ToString() );
                    newqty = qty - Int64.Parse(txtNoOfUnits.Text);

                    if(newqty >= 0)
                    {
                        //To add new Row to DataGridView First use 
                        //
                        //  dgv.Rows.Add();     this will add new row to the Dataridview

                        //Adds a New Row to the DataGridView and returns its index
                        int i = guna2DataGridView1.Rows.Add();

                        guna2DataGridView1.Rows[i].Cells[0].Value = txtMedID.Text;
                        guna2DataGridView1.Rows[i].Cells[1].Value = txtMedName.Text;
                        guna2DataGridView1.Rows[i].Cells[2].Value = guna2DateTimePickerExpire.Text;
                        guna2DataGridView1.Rows[i].Cells[3].Value = txtPricePerUnit.Text;
                        guna2DataGridView1.Rows[i].Cells[4].Value = txtNoOfUnits.Text;
                        guna2DataGridView1.Rows[i].Cells[5].Value = txtTotalPrice.Text;


                        //calculate total amount
                        val += int.Parse(txtTotalPrice.Text);

                        //Show total amount
                        int valamount = 0;
                        for (int j = 0; j < guna2DataGridView1.Rows.Count; j++)
                        {

                            valamount += int.Parse(guna2DataGridView1.Rows[j].Cells[5].Value.ToString());

                        }

                        labelTotalAmount.Text = valamount.ToString();




                        //update DAtabase decrease quantity of sold products
                        query = "update medicine set medQty ='"+newqty+"' WHERE medid='"+txtMedID.Text+"'";
                        dbase.setData(query, "Medicine added...");

                    }
                    else
                    {
                        //inform user
                        MessageBox.Show("Not sufficient product left.Available quantity="+ qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //reload Form : Çünkü database 'de tükenen medicine ler listede
                    //artık görünmemelidir
                    clearFromFieds();            //Clear Form
                    listBox1.Items.Clear();      //Clear listbox
                    SellMEdicine_Load(this, null);//reload this From

                    guna2DataGridView1.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearFormFields();
                }


            }
            else
            {
                MessageBox.Show("First select a medicine from List ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }



       

        /****if text of no of units is changed******/
        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text != "") {
                try
                {
                    txtTotalPrice.Text = (int.Parse(txtPricePerUnit.Text) * int.Parse(txtNoOfUnits.Text)).ToString();
                }
                catch (Exception ex)
                {
                  //  MessageBox.Show("Please enter a valid number for 'Number of units' field !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    //clearFormFields();
                }
            }
            else
            {
                txtTotalPrice.Clear();
            }
           
        }


        int decreasedTotPrice;
        string decreasedID;
        Int64 noOfUnits;
        int selectedRow;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                
                    //get Removed item's quantity and id from DataGridView
                    decreasedTotPrice = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    decreasedID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    noOfUnits = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    selectedRow = e.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //clearFormFields();
            }


        }


        /*******remove from table*******/
        private void btnRemove_Click(object sender, EventArgs e)
        {

            //if any row is selected on datagridview
            if (decreasedID != null && guna2DataGridView1.Rows.Count != 0 )
            {

                try
                {
                    //getting selected Row's index
                    guna2DataGridView1.Rows.
                        RemoveAt(selectedRow);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("First select any row from table to delete it!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                finally
                {
                    try
                    {
                        //get current quantity from DB
                        query = "select medQty from medicine where medid='" + decreasedID + "'";
                        DataSet DS = dbase.getData(query);
                        int qtycurrent = int.Parse(DS.Tables[0].Rows[0][0].ToString());
                        Int64 qtynew = qtycurrent + noOfUnits;

                        //return item to DB
                        query = "update Medicine set medQty=" + qtynew + " WHERE medid='" + decreasedID + "'";
                        dbase.setData(query, "Medicine removed from Cart ...");

                        // labeltotalamount label
                        //decreasedQty is price!
                        // labelTotalAmount.Text = (int.Parse(labelTotalAmount.Text)-decreasedTotPrice).ToString();

                        if (guna2DataGridView1.Rows.Count > 0)
                        {
                            int valamount = 0;
                            for (int j = 0; j < guna2DataGridView1.Rows.Count; j++)
                            {

                                valamount += int.Parse(guna2DataGridView1.Rows[j].Cells[5].Value.ToString());

                            }

                            labelTotalAmount.Text = valamount.ToString();

                        }
                        else
                        {
                            labelTotalAmount.Text = "0";      
                        }         
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                //reload this from
                clearFromFieds();
                listBox1.Items.Clear();
                SellMEdicine_Load(this, null);

                ///!!!!!!UNSELECT ROWA
                guna2DataGridView1.ClearSelection();

            }
            else
            {
                MessageBox.Show("No row selected !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }







        /***********if clear is clicked********/

        private void guna2Button1_Click(object sender, EventArgs e)
         {

           
         }
        /***********Clear selections from table************/
        private void SellMEdicine_MouseUp(object sender, MouseEventArgs e)
        {
            guna2DataGridView1.ClearSelection();

        }

        /***************if purchase is clicked************/
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //selecting document for dialog
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() ==DialogResult.OK )
            {
                printDocument1.Print(); //begins regular printing process ...
                //a dialog screen let you choose your printing machine etc...
            }

           

           
        }

        //print page event occurs when we selected our printing device and
        //press print button
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //string
            string str = "\tMEDICINE BILL\t \n";

            str += guna2DataGridView1.Columns[0].HeaderText + "\t";
            str += guna2DataGridView1.Columns[1].HeaderText + "\t";
            str += guna2DataGridView1.Columns[2].HeaderText + "\t";
            str += guna2DataGridView1.Columns[3].HeaderText + "\t";
            str += guna2DataGridView1.Columns[4].HeaderText + "\t";
            str += guna2DataGridView1.Columns[5].HeaderText + "\t";

            str += "\n";
            str += "   ";

            for (int i = 0; i<guna2DataGridView1.Rows.Count ;i++) {
                for (int j = 0; j<6;j++) {
                    
                    str += guna2DataGridView1.Rows[i].Cells[j].Value.ToString() + "\t";

                    if (j == 5)
                        str += "\n";
                }
            }

            str += "\tHAVE A NICE DAY ...\t \n";


            //string is table's content created above
            //e allows us to CREATE Graphics because PDF file is a Graphics.
            //we can DrawString,DrawRectangles,DrawCircles etc...
            e.Graphics.DrawString(str,
                new Font("Arial",12,FontStyle.Regular),
                Brushes.Black,50,50 );

            //inform user
            MessageBox.Show("Your bill is printed ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        /********clear function***********/
        public void clearFromFieds()
        {
            //clear from fields
            txtMedID.Clear();
            txtMedName.Clear();
            guna2DateTimePickerExpire.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnits.Text = "0";
            txtTotalPrice.Text="0";
           
         
        }

    }
}
