using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LibYourself
{
    public partial class addItem : Form
    {
        public String tableName;
        public addItem(String tableName)
        {

            InitializeComponent();
            this.tableName = tableName;
        }
        
        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void attribute_Click(object sender, EventArgs e)
        {

        }
    }
}
