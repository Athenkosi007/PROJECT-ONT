using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Class1
    {
        Information dal = new Information();
        public int AddProvince(Information pro)
        {
            return dal.AddProvince(pro);
        }
        public DataTable ListProvince(Information pro)
        {
            return dal.ListProvince(pro);
        }
        public DataTable UpdateProvince(Information pro)
        {
            return dal.UpdateProvince(pro);
        }
        public int AddCity(Information pro)
        {
            return dal.AddCity(pro);
        }
        public DataTable ListCity()
        {
            return dal.ListCity();
        }
        public DataTable UpdateCity(Information pro)
        {
            return dal.UpdateCity(pro);
        }
        public int AddSurbub(Information pro)
        {
            return dal.AddSurbub(pro);
        }
        public DataTable ListSurbub()
        {
            return dal.ListSurbub();
        }
        public DataTable DeleteSurbub(Information pro)
        {
            return dal.DeleteSurbub(pro);
        }
        public DataTable cmbSurbub(Information pro)
        {
            return dal.cmbSurbub(pro);
        }
        public DataTable cmbProvince(Information pro)
        {
            return dal.cmbProvince(pro);
        }
        public DataTable cityReport(Information pro)
        {
            return dal.cityReport(pro);
        }
        public DataTable cmbCity(Information pro)
        {
            return dal.cmbCity(pro);
        }
        public int AddProperty(Information pro)
        {
            return dal.AddProperty(pro);
        }
        public DataTable ListProperty()
        {
            return dal.ListProperty();
        }
        public DataTable UpdatePropety(Information pro)
        {
            return dal.UpdateProperty(pro);
        }
        public DataTable DeleteProperty(Information pro)
        {
            return dal.DeleteProperty(pro);
        }
    }
}
