using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmRegistration());

            var client = new ERPService.ERPServiceClient();
            client.OpenConnection();
            MessageBox.Show(client.ExecuteScalar("select * from tblAccount").ToString());
        }
    }
}
