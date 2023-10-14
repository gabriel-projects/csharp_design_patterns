using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.SingletonPattern
{
    public class DbContext
    {

        private DbContext()
        {
            
        }

        private static DbContext context = null;
        public static DbContext Context 
        { 
            get
            { 
                 if(context == null)
                 {
                    context = new DbContext();
                    Console.WriteLine("Instancia DbContext criada");
                 }

                 return context;
            }
        } 

        public void ExecuteQuery(string query)
        {
            Console.WriteLine(query);
        }
    }
}
