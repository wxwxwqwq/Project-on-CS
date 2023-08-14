using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataBsae;
using System.Data;

namespace WebApplication3
{
    
    [WebService(Namespace = "http://wxwx.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public int Registration(string login, string password, string first_name, string last_name, string role)
        {
            return WorkWithDB.InsertUser(login, password, first_name, last_name, role);
        }

        [WebMethod]
        public string[] Authorization(string login, string password)
        {
            return WorkWithDB.FindUser(login, password);
        }

        [WebMethod]
        public List<string[]> Select()
        {
            return WorkWithDB.Select();
        }

        [WebMethod]
        public void UpdateUser(string id)
        {
            WorkWithDB.UpdateUser(id);
        }

        [WebMethod]
        public void DeleteAdmin(string id)
        {
            WorkWithDB.DeleteAdmin(id);
        }

        [WebMethod]
        public List<string[]> SelectAdmins()
        {
            return WorkWithDB.SelectAdmins();
        }



        [WebMethod]
        public void InsertWarehouse(string address, string capacity)
        { 
            WorkWithDB.InsertWarehouse(address, capacity);
        }

        [WebMethod]
        public List<string[]> SelectWarehouses()
        {
            return WorkWithDB.SelectWarehouses();
        }

        [WebMethod]
        public void DeleteWarehouse(string id)
        {
            WorkWithDB.DeleteWarehouse(id);
        }

        [WebMethod]
        public void AddInWarehouse(string id)
        {
            WorkWithDB.AddInWarehouse(id);
        }

        [WebMethod]
        public void DelInWarehouse(string id)
        {
            WorkWithDB.DelInWarehouse(id);
        }



        [WebMethod]
        public void InsertParcel(string id, string name, string warehouse, DateTime date)
        {
            WorkWithDB.InsertParcel(id, name, warehouse, date);
        }

        [WebMethod]
        public List<string[]> SelectParcels()
        {
            return WorkWithDB.SelectParcels();
        }

        [WebMethod]
        public List<string[]> SelectUserParcels(string id)
        {
            return WorkWithDB.SelectUserParcels(id);
        }

        [WebMethod]
        public void DeleteParcel(string id)
        {
            WorkWithDB.DeleteParcel(id);
        }



        [WebMethod]
        public void InsertLink(string passport, string number)
        {
            WorkWithDB.InsertLink(passport, number);
        }

        [WebMethod]
        public List<string[]> SelectLink()
        {
            return WorkWithDB.SelectLink();
        }

        [WebMethod]
        public void DeleteLink(string id)
        {
            WorkWithDB.DeleteLink(id);
        }

        
    }
}
