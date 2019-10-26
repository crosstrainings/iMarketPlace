using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace iMarketPlace.Web.Models
{
    public static class AdvertisementManager
    {
        static AdvertisementManager()
        {
        }


        public static bool Add(Advertisement advertisement)
        {
            SqlConnection connection = new SqlConnection("Data Source=CRLHL-AHMEDIRS2;Initial Catalog=iMarketPlaceDataBase;Integrated Security=True");
            SqlCommand command = new SqlCommand($@"INSERT INTO Advertisements(Title,Price,Category,[Image])
                                                        VALUES('{advertisement.Title}', '{advertisement.Price}', 
                                                        {advertisement.Category}, '{advertisement.Image}')",connection);
            connection.Open();
            command.ExecuteNonQuery();
            return true;
        }

        public static List<Advertisement> Get()
        {
            List<Advertisement> advertisements= new List<Advertisement>();
            SqlConnection connection = new SqlConnection("Data Source=CRLHL-AHMEDIRS2;Initial Catalog=iMarketPlaceDataBase;Integrated Security=True");
            SqlCommand command = new SqlCommand($@"SELECT * FROM Advertisements", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Advertisement ad = new Advertisement();

                ad.Title = reader.GetString(0);
                ad.Price = reader.GetString(1);
                ad.Category = reader.GetInt32(2);
                ad.Image = reader.GetString(3);
                advertisements.Add(ad);
            }

            return advertisements;


        }
    }
}
