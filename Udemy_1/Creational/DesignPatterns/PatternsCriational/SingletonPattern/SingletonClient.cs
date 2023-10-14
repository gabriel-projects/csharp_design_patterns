using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriational.SingletonPattern
{
    public class SingletonClient
    {
        public void ConsumeDb()
        {
            var instance = DbContext.Context;
            instance.ExecuteQuery("select * from users");


            instance = DbContext.Context;
            instance.ExecuteQuery("select * from userdetails");
        }
    }
}
