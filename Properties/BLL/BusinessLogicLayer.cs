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
        DataAccessLayer dal = new DataAccessLayer();

        public int AddPropertyType(Information info)/*1.MANAGE PROPERTY TYPE(ADD, DISPLAY, UPDATE AND DELETE)*/
        {
            return dal.AddPropertyType(info);
        }
        public DataTable DisplayPropertyType()/*1. DISPLAY PROPERTY TYPE*/
        {
            return dal.listPropertyType();
        }
        public int UpdatePropertyType(Information info)/*1UPDATE PROPERTY TYPE*/
        {
            //MISSING METHOD IN THE DAL
            //return dal.; 
            return -1;
        }
        public int AddProperty(Information info)/*2MANAGE PROPERTY(ADD AND DISPLAY)*/
        {
            return dal.AddProperty(info);
        }
        public DataTable DisplayProperty()/*2DISPLAY PROPERTY*/
        {
            return dal.listProperty();
        }
        public int AddProvince(Information info)/*3MANAGE PROVINCE (ADD PROVINCE)*/
        {
            return dal.AddCity(info);
        }
        public DataTable DisplayProvince()/*3DISPLAY PROVINCE*/
        {
            return dal.listProvince();
        }
        public int AddCity(Information info)/*4 MANAGE CITIES(ADD CITIES)*/
        {
            return dal.AddCity(info);
        }

        public DataTable DisplayCity()/*4 DISPLAY CITIES*/
        {
            return dal.ListCity();
        }
        public int AddSurburb(Information info)/*5 MANAGE SURBURB(ADD SUBURB)*/
        {
            return dal.AddSurbub(info);
        }
        public DataTable DisplaySuburb()/*5DISPLAY SUBURB*/
        {
            return dal.ListSurbub();
        }
    }
}
