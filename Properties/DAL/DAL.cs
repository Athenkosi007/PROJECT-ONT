using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //CLASSES 
    public class Cities //4
    {
        public int CityID { get; set; }
        public string CityDescription { get; set; }
        public int ProvinceID { get; set; }
        
    }
    public class Surbub //5
    {
        public int SurbubID {get; set; }
        public string SurbubDescription { get; set; }
        public int PostalCode { get; set; }
        public int CityID { get; set; }

    }
    public class Agencies //6
    {
        public int AgencyID { get; set; }
        public string AgencyName { get; set; }
        public int SurbubID { get; set; }

    
    }

    public class Agent //7) Manage Agent (Add, Update (Email, Phone, Status), Display, and Delete)

    {
        public int AgentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

    }
    public class Tenant//8) Manage Tenant (Add, Update (Email, Phone, Status), Display, and Delete)
    {
        public int TenantID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
    }

    public class PropertyAgent//9) Manage Property Agent (Add, Update (PropertyID, AgentID, Date), Display)
    {
        public int PropertyID { get; set; }
        public int PropertyAgentID { get; set; }
        public int AgentID { get; set; }
        public string date { get; set; }
    }
    public class Rental//10) Manage Rental (Add, Update (StartDate, EndDate), Display)
    {
        public int RentalID { get; set; }
        public int PropertyAgentID { get; set; }
        public int TenantID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
    public class Property 
    {
        public  int PropertyID { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public byte Image { get; set; }
        public int PropertyType {get;set;}
        public string Status { get; set;}
        public int Surbub { get; set;}
    }
    public class PropertyType
    {

    }


}
