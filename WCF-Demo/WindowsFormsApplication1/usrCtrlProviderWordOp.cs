using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class usrCtrlProviderWordOp : UserControl
    {
        public usrCtrlProviderWordOp()
        {
            InitializeComponent();
        }

        public string Year
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        public string Type
        {
            get
            {
                return label2.Text;
            }

            set
            {
                label2.Text = value;
            }
        }

        public string Text
        {
            get
            {
                return label3.Text;
            }

            set
            {
                label3.Text = value;
            }
        }

        public DataGridView datagridview
        {
            get
            {
                return dataGridView1;
            }
        }

    }
}
