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
    public partial class PharDashboard : UserControl
    {
        public PharDashboard()
        {
            InitializeComponent();
        }

        /******DB functions****************/
        DBfunc dbase = new DBfunc();
        string query;

        /*****if this form is loaded*****************/
        private void PharDashboard_Load(object sender, EventArgs e)
        {

            try
            {
                //getDate() is built in function of MSSQL,returns today.
                query = "select count(medname) from Medicine WHERE medExpDate < getDate()";
                DataSet DS = dbase.getData(query);
                int expiredno = int.Parse(DS.Tables[0].Rows[0][0].ToString());

                query = "select count(medname) from Medicine WHERE medExpDate > getDate()";
                DataSet DS2 = dbase.getData(query);
                int validno = int.Parse(DS2.Tables[0].Rows[0][0].ToString());

                //show values on chart
                //selects Serie by index,and Points returns this Serie's x,y values.
                //AddXY() is used to add x,y value for this serie.
                //
                this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart", validno);
                this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine ValidityChart", expiredno);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clearFormFields();
            }

        }

        private void btnDashRefresh_Click(object sender, EventArgs e)
        {
            //clear points for Series 
            this.chart1.Series["Valid Medicines"].Points.Clear();
            this.chart1.Series["Expired Medicines"].Points.Clear();

            //reload page
            PharDashboard_Load(this, null);
        }
    }
}
