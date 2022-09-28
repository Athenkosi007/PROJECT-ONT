using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {
        static string ConnString = "Data Source = localhost; Initial Catalog = RentalDB;  Integrated Security = true;";
        SqlConnection dbConn = new SqlConnection(ConnString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public int AddCity(Cities city)
        {
            dbConn.Open();
            dbComm = new SqlCommand("AddCity_sp", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityDescription", city.CityDescription);
            dbComm.Parameters.AddWithValue("@Province", city.ProvinceID);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
    }

}
