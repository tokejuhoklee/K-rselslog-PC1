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

        public static void nyLogKmKørt(int kmIndtast,int bruger,int bil)
        {
            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (kmKørtBruger,kmKørtBil,opretForbindelse) VALUES (@kmKørtBruger,@kmKørtBil,@tid)", connect);
            cmd.Parameters.AddWithValue("@kmKørtBruger", kmIndtast + " km, bruger Nr.:" + bruger);
            cmd.Parameters.AddWithValue("@kmKørtBil", kmIndtast + " km, bil Nr.:" + bil);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }



        public static void nyLogRedigering(string handling)
        {
       

            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (redigering, opretForbindelse) VALUES (@redigering,@tid)", connect);
            cmd.Parameters.AddWithValue("@redigering", handling);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }

    }
}
