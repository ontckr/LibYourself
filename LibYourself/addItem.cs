using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void getAttributes()
        {

        }
    }
}
