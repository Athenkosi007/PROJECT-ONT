﻿using System;
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
        public DataTable UpdateProvince()
        {
            return dal.UpdateProvince();
        }
        public int AddCity(City city)
        {
            return dal.AddCity(city);
        }
        public DataTable ListCity()
        {
            return dal.ListCity();
        }
        public DataTable UpdateCity(City city)
        {
            return dal.UpdateCity(city);
        }
        public int AddSurbub(Surbub sub)
        {
            return dal.AddSurbub(sub);
        }
        public DataTable ListSurbub()
        {
            return dal.ListSurbub();
        }
        public DataTable DeleteSurbub(Surbub sub)
        {
            return dal.DeleteSurbub(sub);
        }
        public DataTable cmbSurbub()
        {
            return dal.cmbSurbub();
        }
        public DataTable cmbProvince()
        {
            return dal.cmbProvince();
        }
        public DataTable cityReport(string desc)
        {
            return dal.cityReport(desc);
        }
        public DataTable cmbCity()
        {
            return dal.cmbCity();
        }
        public int AddProperty(Property prop)
        {
            return dal.AddProperty(prop);
        }
        public DataTable ListProperty()
        {
            return dal.ListProperty();
        }
        public DataTable UpdatePropety(Property prop)
        {
            return dal.UpdateProperty(clas);
        }
        public DataTable DeleteProperty(Property prop)
        {
            return dal.DeleteProperty(clas);
        }
    }
}
