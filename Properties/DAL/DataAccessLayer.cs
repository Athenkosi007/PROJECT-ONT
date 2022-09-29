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
        static string connString = @"Data Source=DESKTOP-KKRET85\SQLEXPRESS;Initial Catalog = records; Integrated Security = True;";
        SqlConnection dbconn = new SqlConnection(connString);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;


        public int AddCity(Cities city)
        {
            dbconn.Open();
            cmd = new SqlCommand("AddCity_sp", dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CityDescription", city.CityDescription);
            cmd.Parameters.AddWithValue("@Province", city.ProvinceID);

            if (dbconn.State == ConnectionState.Closed)
            {
                dbconn.Open();
            }

            int x = cmd.ExecuteNonQuery();
            return x;
        }

        public int AddAgent(Agent age)
        {
            dbconn.Open();
            string sql = "AddAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", age.Name);
            cmd.Parameters.AddWithValue("@Surname", age.Surname);
            cmd.Parameters.AddWithValue("Agent ID", age.AgentID);
            cmd.Parameters.AddWithValue("@Email", age.Email);
            cmd.Parameters.AddWithValue("@Password", age.Password);
            cmd.Parameters.AddWithValue("@Status", age.Status);
            cmd.Parameters.AddWithValue("@Phone", age.Phone);
            int x = cmd.ExecuteNonQuery();
            dbconn.Close();

            return x;
        }

        public DataTable ListAgent()
        {
            dbconn.Open();
            string sql = "ListAgency_sp";
            cmd = new SqlCommand(sql, dbconn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            dbconn.Close();
            return dt;
        }
        public DataTable UpdateAgent(Agent age)
        {
            dbconn.Open();
            string sql = "UpdateAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", age.Name);
            cmd.Parameters.AddWithValue("@Surname", age.Surname);
            cmd.Parameters.AddWithValue("Agent ID", age.AgentID);
            cmd.Parameters.AddWithValue("@Email", age.Email);
            cmd.Parameters.AddWithValue("@Password", age.Password);
            cmd.Parameters.AddWithValue("@Status", age.Status);
            cmd.Parameters.AddWithValue("@Phone", age.Phone);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            //  int x = cmd.ExecuteNonQuery();
            dbconn.Close();
            return dt;
        }

        public DataTable DeleteAgent(Agent age)
        {
            dbconn.Open();

            string sql = "DeleteAgent_sp";

            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Agent ID", age.AgentID);

            int x = cmd.ExecuteNonQuery();

            adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();

            adapter.Fill(dt);

            //dgvList.DataSource = dt;

            dbconn.Close();
            return dt;

        }
        public int AddTenant(Tenant tenant)
        {
            dbconn.Open();
            string sql = "AddTenant_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", tenant.Name);
            cmd.Parameters.AddWithValue("@Surname", tenant.Surname);
            cmd.Parameters.AddWithValue("TenantID", tenant.TenantID);
            cmd.Parameters.AddWithValue("@Email", tenant.Email);
            cmd.Parameters.AddWithValue("@Password", tenant.Password);
            cmd.Parameters.AddWithValue("@Status", tenant.Status);
            cmd.Parameters.AddWithValue("@Phone", tenant.Phone);
            int x = cmd.ExecuteNonQuery();
            dbconn.Close();

            return x;

        }
        public DataTable UpdateTenant(Tenant tenant)
        {
            dbconn.Open();
            string sql = "UpdateTenant_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", tenant.Name);
            cmd.Parameters.AddWithValue("@Surname", tenant.Surname);
            cmd.Parameters.AddWithValue("Tenant", tenant.TenantID);
            cmd.Parameters.AddWithValue("@Email", tenant.Email);
            cmd.Parameters.AddWithValue("@Password", tenant.Password);
            cmd.Parameters.AddWithValue("@Status", tenant.Status);
            cmd.Parameters.AddWithValue("@Phone", tenant.Phone);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            //  int x = cmd.ExecuteNonQuery();
            dbconn.Close();
            return dt;
        }
        public DataTable ListTenant()
        {
            dbconn.Open();
            string sql = "ListTenant_sp";
            cmd = new SqlCommand(sql, dbconn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            dbconn.Close();
            return dt;

        }

        public DataTable DeleteTenant(Tenant tenant)
        {
            dbconn.Open();

            string sql = "DeleteTenant_sp";

            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("TenantID", tenant.TenantID);

            int x = cmd.ExecuteNonQuery();

            adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();

            adapter.Fill(dt);

            //dgvList.DataSource = dt;

            dbconn.Close();
            return dt;
        }

        public int AddPropertyAgent(PropertyAgent propAgent)
        {
            dbconn.Open();
            string sql = "AddPropertyAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PropertyID", propAgent.PropertyID);
            cmd.Parameters.AddWithValue("@PrpertyAgentID", propAgent.PropertyAgentID);
            cmd.Parameters.AddWithValue("Agent ID", propAgent.AgentID);
            cmd.Parameters.AddWithValue("@Date", propAgent.date);

            int x = cmd.ExecuteNonQuery();
            dbconn.Close();

            return x;
        }

        public DataTable listPropertyAgent()
        {
            dbconn.Open();
            string sql = "ListPropertyAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            dbconn.Close();
            return dt;
        }

        public DataTable UpdatePropertyAgent(PropertyAgent propAgent)
        {
            dbconn.Open();
            string sql = "UpdatePropertyAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PropertyID", propAgent.PropertyID);
            cmd.Parameters.AddWithValue("@PrpertyAgentID", propAgent.PropertyAgentID);
            cmd.Parameters.AddWithValue("Agent ID", propAgent.AgentID);
            cmd.Parameters.AddWithValue("@Date", propAgent.date);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            //  int x = cmd.ExecuteNonQuery();
            dbconn.Close();
            return dt;
        }

        public int AddRental(Rental rental)
        {
            dbconn.Open();
            string sql = "AddRental_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RentalID", rental.RentalID);
            cmd.Parameters.AddWithValue("@PrpertyAgentID", rental.PropertyAgentID);
            cmd.Parameters.AddWithValue("TenantID", rental.TenantID);
            cmd.Parameters.AddWithValue("@StartDate", rental.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", rental.EndDate);

            int x = cmd.ExecuteNonQuery();
            dbconn.Close();

            return x;
        }
        public DataTable ListRental(Rental rent)
        {
            dbconn.Open();
            string sql = "ListPropertyAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            dbconn.Close();
            return dt;
        }
        public DataTable Update(Rental rent)
        {
            dbconn.Open();
            string sql = "UpdateRental_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RentalID", rent.RentalID);
            cmd.Parameters.AddWithValue("@PrpertyAgentID", rent.PropertyAgentID);
            cmd.Parameters.AddWithValue("TenantID", rent.TenantID);
            cmd.Parameters.AddWithValue("@StartDate", rent.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", rent.EndDate);
            return dt;
        }

    }

}
