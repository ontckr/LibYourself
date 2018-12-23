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
    public partial class editLibrary : Form
    {
        private List<String> attributes;
        private String tableName;

        public editLibrary(String tableName,List<String> attributes)
        {
            InitializeComponent();
            this.attributes = attributes;
            this.tableName = tableName;

            foreach(String attribute in attributes)
            {
                listBox1.Items.Add(attribute);
            }

            editLibraryName.Text = tableName;
        }

        private void editLibraryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void editNewAttribute_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editAddButton_Click(object sender, EventArgs e)
        {
            if (this.editNewAttribute.Text != "")
            {
                listBox1.Items.Add(this.editNewAttribute.Text);
                this.editNewAttribute.Focus();
                this.editNewAttribute.Clear();
            }

            else if (editNewAttribute.Text == "")
            {
                MessageBox.Show("burayı boş bırakamazsınız", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editDeleteAttribute_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }
        
        private void deleteLibrary_Click(object sender, EventArgs e)
        {
            //delete libraray
        }

        private void saveLibrary_Click(object sender, EventArgs e)
        {

        }

    }
}
