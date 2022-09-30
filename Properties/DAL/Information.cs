using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Information
    {
        //CLASSES VARIABLES

        // 1.MANAGE PropertyType VARIABLES
        public int PropertyTypeID { get; set; }
        public string PropertyTypeDescription { get; set; }

        // 2. MANAGE Properties VARIABLES
        public int PropertyID { get; set; }
        public string PropertyDescription { get; set; }
        public float PropertyPrice { get; set; }
        public byte PropertyImage { get; set; }
        public int FPropertyTypeID { get; set; }
        public string PropertyStatus { get; set; }
        public int FpropertySurbubID { get; set; }

        //3. MANAGE Province Variables
        public string ProvinceID { get; set; }
        public string ProvDescription { get; set; }

        //4.MANAGE Cities Variable 
        public int CityID { get; set; }
        public string CityDescription { get; set; }
        public int FProvinceID { get; set; }

        //5.MANAGE SURBURB VARIABLES 
        public int SurbubID { get; set; }
        public string SurbubDescription { get; set; }
        public int PostalCode { get; set; }
        public int FCityID { get; set; }

    //6.MANAGE AGENCIES VARIABLES 
        public int AgencyID { get; set; }
        public string AgencyName { get; set; }
        public int FagencySurbubID { get; set; }


    //7.MANAGE Agent VARIABLES  

        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public string AgentSurname { get; set; }
        public string AgentPhone { get; set; }
        public string AgentPassword { get; set; }
        public string AgentEmail { get; set; }
        public string AgentStatus { get; set; }
        public int FagencyID { get; set; }

    //8.MENAGE Tenant VARIABLES 
        public int TenantID { get; set; }
        public string TenantName { get; set; }
        public string TenantSurname { get; set; }
        public string TenantEmail { get; set; }
        public string TenantPassword { get; set; }
        public string TenantPhone { get; set; }
        public string TenantStatus { get; set; }

    //9.MANAGE PropertyAgent VARIABLES
        public int FPropertyID { get; set; }
        public int PropertyAgentID { get; set; }
        public int FAgentID { get; set; }
        public string date { get; set; }
        
    //10.MANAGE Rental VARIABLES
        public int RentalID { get; set; }
        public int FPropertyAgentID { get; set; }
        public int FTenantID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
       
       
    }
}
