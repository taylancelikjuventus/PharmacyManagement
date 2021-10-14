using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    class DBfunc
    {
        
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
               
                conn.ConnectionString = "data source=DESKTOP-C8BKT6R\\SQLEXPRESS01 ;database=pharmacymanagementsystem ;integrated security=true ;";
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return conn;
            }

            

        }
      
        public DataSet getData(string query)
        {
            DataSet DS = new DataSet();
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                
                DA.Fill(DS);

                conn.Close();

                return DS;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DS;
            }

        }



      
        public void setData(string query,string msg)
        {
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }









    }
}
