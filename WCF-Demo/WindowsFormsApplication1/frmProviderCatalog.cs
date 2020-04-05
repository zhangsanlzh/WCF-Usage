using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class frmProviderCatalog : Form
    {
        public frmProviderCatalog()
        {
            InitializeComponent();
        }

        private void ProviderCatalog_Load(object sender, EventArgs e)
        {
            var word = new ProviderWordOperation();

            var tbXml = word.GetTableXml(@"C:\Users\lzh\Desktop\mulu.docx", 0);
            usrCtrlProviderWordOp1.Year = word.GetYear(tbXml);
            usrCtrlProviderWordOp1.Type = word.GetType(tbXml);
            usrCtrlProviderWordOp1.Text = word.GetText(tbXml);
            DataSet ds = word.Convert(tbXml);
            usrCtrlProviderWordOp1.datagridview.DataSource = ds.Tables["Data"];

            var tbXml1 = word.GetTableXml(@"C:\Users\lzh\Desktop\mulu.docx", 1);
            usrCtrlProviderWordOp2.Year = word.GetYear(tbXml1);
            usrCtrlProviderWordOp2.Type = word.GetType(tbXml1);
            usrCtrlProviderWordOp2.Text = word.GetText(tbXml1);
            DataSet ds1 = word.Convert(tbXml1);
            usrCtrlProviderWordOp2.datagridview.DataSource = ds1.Tables["Data"];

            var tbXml2 = word.GetTableXml(@"C:\Users\lzh\Desktop\mulu.docx", 2);
            usrCtrlProviderWordOp3.Year = word.GetYear(tbXml2);
            usrCtrlProviderWordOp3.Type = word.GetType(tbXml2);
            usrCtrlProviderWordOp3.Text = word.GetText(tbXml2);
            DataSet ds3 = word.Convert(tbXml2);
            usrCtrlProviderWordOp3.datagridview.DataSource = ds3.Tables["Data"];

            var tbXml3 = word.GetTableXml(@"C:\Users\lzh\Desktop\mulu.docx", 3);
            usrCtrlProviderWordOp4.Year = word.GetYear(tbXml3);
            usrCtrlProviderWordOp4.Type = word.GetType(tbXml3);
            usrCtrlProviderWordOp4.Text = word.GetText(tbXml3);
            DataSet ds4 = word.Convert(tbXml3);
            usrCtrlProviderWordOp4.datagridview.DataSource = ds4.Tables["Data"];
        }
    }
}
