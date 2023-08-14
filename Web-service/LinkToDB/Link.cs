using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBsae;
using System.Data;

namespace LinkToDB
{
    public class Link
    {

        public static DataTable Sell()
        {
            return WorkWithDB.Sell();
        }




        public static int Che()
        {
            return WorkWithDB.Che();

        }






    }
}
