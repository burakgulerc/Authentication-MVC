using MVCAuthentication_Tekrar3.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthentication_Tekrar3.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        public DBTool()
        {

        }

        static MyContext _dbInstance;

        public static MyContext DBInstance
        {
            get
            {
                if(_dbInstance is null) _dbInstance = new MyContext();
                return _dbInstance;
            }
        }
    }
}