using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Hotel_Management
{
    class DatabaseRequest
    {

        protected SqlConnection getConnection()
        {
            /*connect to sql server*/
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-XXXXX; database=camillaHotel ;Integrated Security = True";
            return con;

        }

        /*to get data from database*/
        public DataSet getData(String query) { 
        
            /*creat sql connection*/
            SqlConnection con = getConnection();
            /*create sql obect of sql command - new connand*/
            SqlCommand cmd = new SqlCommand();
            /*we pass connectin to that command and the query*/
            cmd.Connection = con;
            cmd.CommandText = query;
            /*get data after send cmd with connicr=tion and query*/
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            /*copy the return data to data set*/
            da.Fill(ds);
            return ds;
        }

        /*insert or delete or update  data in database */
        public void setData(String query, string message)
        {

            /*connect to the database*/
            SqlConnection con = getConnection();
            /*create sql obect of sql command - new connand*/
            SqlCommand cmd = new SqlCommand();
            /*we pass connectin to that command */
            cmd.Connection = con;
            /*open the connection*/
            con.Open();
            /*pass the query to command*/
            cmd.CommandText = query;
            /*execute the query and finally close the conection*/
            cmd.ExecuteNonQuery();
            con.Close();
            /*show massage*/
            MessageBox.Show(" " + message + " " , "Success" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


        public SqlDataReader getDataForComdo(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;

        }

    }
}
