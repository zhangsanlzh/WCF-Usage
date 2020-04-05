using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace ERPService
{
    public class Service : IERPService
    {
        DBHelper helper = null;
        public Service()
        {
            if (helper == null)
                helper = new DBHelper();
        }

        public object ExecuteScalar(string sql)
        {
            return helper.ExecuteScalar(sql);       
        }

        public bool OpenConnection()
        {
            return helper.OpenConnection();    
        }
    }
}
