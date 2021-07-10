using System;
using System.Net.Http;
using System.Data.SqlTypes;

namespace SoccerApp.Task
{
    class Program
    {
        static void Main(string[] args)
        {

            // apiye istek at
            // gelen isteği db ye yaz


            // mvc page isteği geldiğinde service --> database git
            // db'den aldığın verileri kullanıcıya göster
        }
        private static readonly HttpClient client = new HttpClient();
        private SqlConnection SqlConnection;

        void BringData()
        {
            SqlConnection = new SqlConnection("https://s0-sports-data-api.broadage.com");
        }

    }

}
