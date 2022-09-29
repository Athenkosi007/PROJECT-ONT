using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
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


}
