using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.IO;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string file = @"C:\Users\lzh\Desktop\采购表\汇总.xlsx";
            var excel = new RegistrationExcelOperation();
            var xml = excel.GetExcelXml(file);
            xml.Save(@"C:\Users\lzh\Desktop\bxlsx.xml");

            var ds = excel.Convert(xml);
            dataGridView1.DataSource = ds.Tables["Data"];
        }
    }

}
