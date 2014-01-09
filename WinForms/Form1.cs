using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjs;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bsMS.DataSource = new MyDataObject[] { new MyDataObject { Message = "Msg", MessageLength = 3 }, new MyDataObject { Message = "Message", MessageLength = 7 } };
        }

        private void editMessageMS_TextChanged(object sender, EventArgs e)
        {
            var txt = editMessageMS.Text;
            var item = (MyDataObject)bsMS.Current;
            item.MessageLength = txt.Length;
        }
    }
}
