using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ERPService
{
    [ServiceContract]
    public interface IERPService
    {
        [OperationContract]
        bool OpenConnection();

        [OperationContract]
        object ExecuteScalar(string sql);

    }
}
