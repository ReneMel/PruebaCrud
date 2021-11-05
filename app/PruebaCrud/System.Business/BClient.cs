using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DData;
using System.Data;
using System.Entities;


namespace System.Business
{
    public class BClient
    {
        public  static DataTable ListClients()
        {
            DClient dc = new DClient();

            return dc.listClients();
        }


        public static bool deleteClient(int id) {
            DClient dc = new DClient();


            return dc.deleteClient(id);

        }

        public static bool updateClient(string name, string lastname, string dui, DateTime bd, int id) {
            DClient dc = new DClient();
            return dc.updateClient(name, lastname, dui, bd, id);

        }

        public static bool createClient(string name, string lastname, string dui, DateTime bd) {
            DClient dc = new DClient();

            return dc.InsertClient(name, lastname, dui, bd);
        }




    }


}
