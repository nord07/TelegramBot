using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot
{
    internal class SaveImage
    {
        internal static void TestConnection()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                    Console.WriteLine("Connected");
            }
                
        }
        internal static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=10.1.1.192;Port=5432;User Id=a_bochkare;Password=GbDr_J3r;Database=TelegramBot;");
        }
    }
}
