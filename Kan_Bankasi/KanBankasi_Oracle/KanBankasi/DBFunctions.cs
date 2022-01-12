using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;


namespace KanBankasi
{
    class DBFunctions
    {
        public OracleConnection baglantiyiAl()
        {

            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            

            //con.ConnectionString = "Data Source=sys_admin;User Id=/;";
            
            con.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XEPDB1)));User Id=SYSTEM;Password=2256gs;";

           /* con.ConnectionString = "Data Source=(DESCRIPTION =" +
    "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" +
      "(SERVER = DEDICATED)" +
      "(SERVICE_NAME = XEPDB1)));" +
      "User Id=SYSTEM;Password=2256gs;";*/
            return con;
            
        }

        public DataSet veriyiAl(String sorgu)
        {
            OracleConnection con = baglantiyiAl();
            
            OracleCommand cmd = new OracleCommand(sorgu, con);
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            OracleDataAdapter da = new OracleDataAdapter(cmd); 
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
           
            
        }

        public Boolean veriAyarla(String sorgu)
        {
            Boolean control = true;
            try 
            {
                OracleConnection con = baglantiyiAl();
                OracleCommand cmd = new OracleCommand(sorgu, con);
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = sorgu;
                cmd.ExecuteNonQuery();
                con.Close();
                control = true;

            } catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return control;


        }

       
    }
}
