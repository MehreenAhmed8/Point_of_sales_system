using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Controls; 
using System.Threading.Tasks;
using POS.Model;
namespace POS.Database
{
    public class dB
    {
         static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Inam\POS(orignal)\POS\POS\Database\DatabasePos.mdf;Integrated Security=True";
           static SqlConnection conn;


        public static void AddDataGrid(DataGrid x , string total)
        {
            try
            {
                string id="-1";
                conn = new SqlConnection(connString);
                conn.Open();

                List<Data> L1 = new List<Data>();
                string date = DateTime.Now.ToString("yyyy/MM/dd-hh:mm:ss");

                L1 = HelperClass.GetList(x);
                string tempdate = date; 
                string query = $"Insert into [Order] (Date,Total) values ('{tempdate}','{total}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int sucess = cmd.ExecuteNonQuery();
                conn.Close();
                if (sucess >= 0)
                {

                    string query1= "SELECT * FROM [Order] WHERE  Date = '" + tempdate + "'";
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand(query1, conn);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {

                        id = dr.GetValue(0).ToString();
                    }
                    else
                    {
                        ((MainWindow)System.Windows.Application.Current.MainWindow).total.Content = "null";
                    }
                    conn.Close();

                    if (id != "-1")
                    {
                        for (int i = 0; i < L1.Count; i++)
                        {
                            conn.Open();
                            string query2 = $"Insert into [OrderDetail] (OrderId,ItemName,quantity) values ({Convert.ToInt32(id)},'{L1[i].Name}','{L1[i].QTY}')";
                            SqlCommand cmd2 = new SqlCommand(query2, conn);

                            int sucess1 = cmd2.ExecuteNonQuery();

                            conn.Close();

                        }
                    }

                }



            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                throw;
            }

        }
}
}