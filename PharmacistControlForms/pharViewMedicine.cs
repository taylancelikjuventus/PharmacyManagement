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
    public partial class pharViewMedicine : UserControl
    {
        public pharViewMedicine()
        {
            InitializeComponent();
        }

        /******DB functions****************/
        DBfunc dbase = new DBfunc();
        string query;


        /********if page loads show all medicine on table ********/
        private void pharViewMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select * from Medicine";
                DataSet DS = dbase.getData(query);

                if (DS.Tables[0].Rows.Count != 0)
                {
                    guna2DataGridView1.DataSource = DS.Tables[0];
                }
                else
                {
                    guna2DataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clearFormFields();
            }

        }

        private void txtPharVMMedName_TextChanged(object sender, EventArgs e)
        {
            if(txtPharVMMedName.Text != "")
            {

                try
                {
                    //filter medicines by Name
                    query = "select * from Medicine WHERE medname LIKE '"+txtPharVMMedName.Text+"%'";
                    DataSet DS = dbase.getData(query);

                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        guna2DataGridView1.DataSource = DS.Tables[0];
                    }
                    else
                    {
                        guna2DataGridView1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearFormFields();
                }

            }else
            {
                //press refresh table
                btnPharViewRefresh.PerformClick();
            }


        }

        private void btnPharViewRefresh_Click(object sender, EventArgs e)
        {
            pharViewMedicine_Load(this, null);
        }



        string medid = "";
        //if any cell of table is clicked get its medicine ID 
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               medid = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clearFormFields();
            }

        }

        //delete selected row from DB
        private void btnPharViewDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this row ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    query = "delete from Medicine WHERE medid='" + medid + "'";
                    dbase.setData(query, "row deleted...");
                    //refresh dataGridView
                    btnPharViewRefresh.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clearFormFields();
                }
            }

        }



    }
}
