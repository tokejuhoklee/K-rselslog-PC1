using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace kørselslog
{
    public class log
    {
       static String credentials = "server=TAK;Initial Catalog=kørsel;User ID=bruger;Password = stop;";
       static DateTime dateTimeVariable = DateTime.Now;

        public static void nyLogBilOpret(string bilSamletNavn)
        {
            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (opretBil,opretForbindelse) VALUES (@opretBil,@tid)", connect);
            cmd.Parameters.AddWithValue("@opretBil", bilSamletNavn);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }
        public static void nyLogBrugerOpret(string fuldNavn)
        {
            SqlConnection connect = new SqlConnection(credentials);
            SqlCommand cmd = new SqlCommand("INSERT INTO log (opretBruger,opretForbindelse) VALUES (@opretBruger,@tid)", connect);
            cmd.Parameters.AddWithValue("@opretBruger", fuldNavn);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }

        public static void nyLogKmKørt(int kmIndtast)
        {
            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (kmKørtBruger,kmKørtBil,opretForbindelse) VALUES (@kmKørtBruger,@kmKørtBil,@tid)", connect);
            cmd.Parameters.AddWithValue("@kmKørtBruger", kmIndtast);
            cmd.Parameters.AddWithValue("@kmKørtBil", kmIndtast);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }



        public void nyLogRedigering()
        {
            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (kmKørtBruger,kmKørtBil,opretBruger,opretBil,opretForbindelse) VALUES (kmKørtBruger,kmKørtBil,opretBruger,opretBil,@tid)", connect);
            cmd.Parameters.AddWithValue("@kmKørtBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@kmKørtBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }
    }
}
