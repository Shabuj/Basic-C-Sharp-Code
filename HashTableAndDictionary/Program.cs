using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HashTableAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Rahim");
            ht.Add(2, "Karim");
            ht.Add(3, "Shabuj");
            foreach(var key in ht.Values)
            {
                Console.WriteLine(key);
            }
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Tuhin");
            dt.Add(2, "Rahima ");
            

            
            foreach(var key in dt.Keys)
            {
                Console.WriteLine(dt[key]);
            }
            List<string> listname = new List<string>();
            listname.Add("BITM");
            listname.Add("BASIS");
            foreach (string data in listname)
            {
                Console.WriteLine(data); 
            }

        }
    }
}
