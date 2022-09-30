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
        static string connString = @"Data Source=localhost; Initial Catalog = records; Integrated Security = True;";
        SqlConnection dbconn = new SqlConnection(connString);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public int AddCity(Information info) //4.Add
        {
            dbconn.Open();
            cmd = new SqlCommand("AddCity_sp", dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CityDescription", info.CityDescription);
            cmd.Parameters.AddWithValue("@Province", info.ProvinceID);

            if (dbconn.State == ConnectionState.Open)
            {
                dbconn.Close();
            }
             
            int x = cmd.ExecuteNonQuery();
            return x;
        }
        public DataTable ListCity() //4 DISPLAY
        {
            dbconn.Open();
            string sql = "ListCity_sp";
            cmd = new SqlCommand(sql, dbconn);
            adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);
            dbconn.Close();
            return dt;
        }

        public int AddSurbub(Information info) //5.ADD
        {
            dbconn.Open();
            cmd = new SqlCommand("AddSurbub_sp", dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SurbubID", sub.SurbubID);
            cmd.Parameters.AddWithValue("@SurbubDescription", sub.SurbubDescription);
            cmd.Parameters.AddWithValue("@PostalCode", sub.PostalCode);
            cmd.Parameters.AddWithValue("@CityID", sub.CityID);

            if (dbconn.State == ConnectionState.Open)
            {
                dbconn.Close();
            }

            int x = cmd.ExecuteNonQuery();
            return x;
        }

        public DataTable ListSurbub() //5.Dispaly
        {
            dbconn.Open();
            string sql = "ListSurbub_sp";
            cmd = new SqlCommand(sql, dbconn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            dbconn.Close();
            return dt;
        }
        public int AddAgency()//6.Add
        {
            dbconn.Open();
            cmd = new SqlCommand("AddAgency_sp", dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AgencyID", ag.AgencyID);
            cmd.Parameters.AddWithValue("@AgencyName", ag.AgencyName);
            cmd.Parameters.AddWithValue("@SurbubID", ag.SurbubID);

            if (dbconn.State == ConnectionState.Open)
            {
                dbconn.Close();
            }

            int x = cmd.ExecuteNonQuery();
            return x;
        }
        public DataTable ListAgency() //6.Dispaly
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
        public DataTable DeleteAgency() //6.Delete
        {
            dbconn.Open();
            string sql = "DeleteAgency_sp";
            cmd = new SqlCommand(sql, dbconn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("AgencyID", ag.AgencyID);

            int x = cmd.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);

            //dgvList.DataSource = dt;
            dbconn.Close();
            return dt;
        }

        public int AddAgent() //7 ADD
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
        public DataTable UpdateAgent()
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

        public DataTable DeleteAgent()
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

        public int AddTenant()
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

        public DataTable UpdateTenant()
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

        public DataTable DeleteTenant()
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

        public int AddPropertyAgent(Information info)
        {
            dbconn.Open();
            string sql = "AddPropertyAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PropertyID", info.FPropertyID);
            cmd.Parameters.AddWithValue("@PrpertyAgentID", info.FPropertyAgentID);
            cmd.Parameters.AddWithValue("Agent ID", info.FAgentID);
            cmd.Parameters.AddWithValue("@Date", info.date);

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

        public DataTable UpdatePropertyAgent(Information info)
        {

            dbconn.Open();
            string sql = "UpdatePropertyAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PropertyID", info.FPropertyID);
            cmd.Parameters.AddWithValue("@PrpertyAgentID", info.FPropertyAgentID);
            cmd.Parameters.AddWithValue("Agent ID", info.FAgentID);

            cmd.Parameters.AddWithValue("@Date", info.date);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            //  int x = cmd.ExecuteNonQuery();
            dbconn.Close();

            return dt;
        }

        public int AddRental(Information info)
        {
            dbconn.Open();
            string sql = "AddRental_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@PrpertyAgentID", info.FPropertyAgentID);
            cmd.Parameters.AddWithValue("TenantID", info.FTenantID);
            cmd.Parameters.AddWithValue("@StartDate", info.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", info.EndDate);

            int x = cmd.ExecuteNonQuery();
            dbconn.Close();

            return x;
        }
        public DataTable ListRental(Information into)
        {
            dbconn.Open();
            string sql = "ListPropertyAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);
            dbconn.Close();
            return dt;
        }
        public DataTable UpdateRental(Information info)
        {
            dbconn.Open();
            string sql = "UpdateRental_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RentalID", info.RentalID);
            cmd.Parameters.AddWithValue("@PrpertyAgentID", info.FPropertyAgentID);
            cmd.Parameters.AddWithValue("TenantID", info.FTenantID);
            cmd.Parameters.AddWithValue("@StartDate", info.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", info.EndDate);
            return dt;
        }

    }
}
