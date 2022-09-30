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

            cmd.Parameters.AddWithValue("@SurbubID", info.SurbubID);
            cmd.Parameters.AddWithValue("@SurbubDescription", info.SurbubDescription);
            cmd.Parameters.AddWithValue("@PostalCode", info.PostalCode);
            cmd.Parameters.AddWithValue("@CityID", info.FCityID);

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
        public int AddAgency(Information info)//6.Add
        {
            dbconn.Open();
            cmd = new SqlCommand("AddAgency_sp", dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AgencyID", info.AgencyID);
            cmd.Parameters.AddWithValue("@AgencyName", info.AgencyName);
            cmd.Parameters.AddWithValue("@SurbubID", info.FagencySurbubID);

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
        public DataTable DeleteAgency(Information info) //6.Delete
        {
            dbconn.Open();
            string sql = "DeleteAgency_sp";
            cmd = new SqlCommand(sql, dbconn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("AgencyID", info.AgencyID);

            int x = cmd.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);

            //dgvList.DataSource = dt;
            dbconn.Close();
            return dt;
        }

        public int AddAgent(Information info) //7 ADD
        {
            dbconn.Open();
            string sql = "AddAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@Name", info.AgentName);
            cmd.Parameters.AddWithValue("@Surname", info.AgentSurname);
            cmd.Parameters.AddWithValue("Agent ID", info.FagencyID);

            cmd.Parameters.AddWithValue("@Email", info.AgentEmail);
            cmd.Parameters.AddWithValue("@Password", info.AgentPassword);
            cmd.Parameters.AddWithValue("@Status", info.AgentStatus);

            cmd.Parameters.AddWithValue("@Phone", info.AgentPhone);
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
        public DataTable UpdateAgent(Information info)
        {
            dbconn.Open();
            string sql = "UpdateAgent_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", info.AgentName);
            cmd.Parameters.AddWithValue("@Surname", info.AgentSurname);
            cmd.Parameters.AddWithValue("Agent ID", info.AgentID);

            cmd.Parameters.AddWithValue("@Email", info.AgentEmail);
            cmd.Parameters.AddWithValue("@Password", info.AgentPassword);
            cmd.Parameters.AddWithValue("@Status", info.AgentStatus);

            cmd.Parameters.AddWithValue("@Phone", info.AgentPhone);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            //  int x = cmd.ExecuteNonQuery();
            dbconn.Close();
            return dt;
        }

        public DataTable DeleteAgent(Information info)
        {
            dbconn.Open();
            string sql = "DeleteAgent_sp";

            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Agent ID", info.AgentID);
            
            int x = cmd.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);
            //dgvList.DataSource = dt;

            dbconn.Close();
            return dt;
        }

        public int AddTenant(Information info)
        {
            dbconn.Open();
            string sql = "AddTenant_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", info.TenantName);
            cmd.Parameters.AddWithValue("@Surname", info.TenantSurname);
            cmd.Parameters.AddWithValue("TenantID", info.FTenantID);

            cmd.Parameters.AddWithValue("@Email", info.TenantEmail);
            cmd.Parameters.AddWithValue("@Password", info.TenantPassword);
            cmd.Parameters.AddWithValue("@Status", info.TenantStatus);
            cmd.Parameters.AddWithValue("@Phone", info.TenantPhone);

            int x = cmd.ExecuteNonQuery();
            dbconn.Close();

            return x;
        }

        public DataTable UpdateTenant(Information info)
        {
            dbconn.Open();
            string sql = "UpdateTenant_sp";
            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", info.TenantName);
            cmd.Parameters.AddWithValue("@Surname", info.TenantSurname);
            cmd.Parameters.AddWithValue("Tenant", info.FTenantID);

            cmd.Parameters.AddWithValue("@Email", info.TenantEmail);
            cmd.Parameters.AddWithValue("@Password", info.TenantPassword);
            cmd.Parameters.AddWithValue("@Status", info.TenantStatus);

            cmd.Parameters.AddWithValue("@Phone", info.TenantPhone);
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

        public DataTable DeleteTenant(Information info)
        {
            dbconn.Open();
            string sql = "DeleteTenant_sp";

            cmd = new SqlCommand(sql, dbconn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("TenantID", info.TenantID);

            int x = cmd.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);
            //dgvList.DataSource = dt;
            dbconn.Close();

            return dt;
        }

        public int AddPropertyAgent()
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

        public DataTable UpdatePropertyAgent()
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

        public int AddRental()
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
        public DataTable ListRental()
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
        public DataTable UpdateRental()
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
