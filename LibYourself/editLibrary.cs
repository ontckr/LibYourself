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
        public String tableName;
        private Form1 form1;
        SQLiteConnection conn = new SQLiteConnection
        {
            ConnectionString = ("Data Source=DataTable.db;")
        };

        public editLibrary(String tableName, List<String> attributes, Form1 form1)
        {
            InitializeComponent();
            this.attributes = attributes;
            this.tableName = tableName;
            this.form1 = form1;

            foreach (String attribute in attributes)
            {
                listBox1.Items.Add(attribute);
            }
        }

        private void editAddButton_Click(object sender, EventArgs e)
        {
            if (this.editNewAttribute.Text != "")
            {
                conn.Open();
                SQLiteCommand addColumn = new SQLiteCommand();
                addColumn.Connection = conn;
                addColumn.CommandText = "ALTER TABLE " + tableName + " ADD COLUMN " + editNewAttribute.Text;
                addColumn.ExecuteNonQuery();
                conn.Close();
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

            String attributeString = "";
            foreach (string attribute in listBox1.Items)
            {
                attributeString += attribute + ",";
            }
            attributeString = attributeString.Remove(attributeString.Length - 1);

            conn.Open();
            SQLiteCommand addColumn = new SQLiteCommand();
            addColumn.Connection = conn;
            addColumn.CommandText = "BEGIN TRANSACTION; CREATE TEMPORARY TABLE t1_backup(" + attributeString +"); INSERT INTO t1_backup SELECT " + attributeString + " FROM " + tableName + "; DROP TABLE " + tableName + "; CREATE TABLE " + tableName+"("+attributeString+"); INSERT INTO " + tableName +" SELECT " + attributeString +" FROM t1_backup; DROP TABLE t1_backup; COMMIT;";
            addColumn.ExecuteNonQuery();
            conn.Close();
        }

        private void deleteLibrary_Click(object sender, EventArgs e)
        {
            conn.Open();
            SQLiteCommand delete = new SQLiteCommand();
            delete.Connection = conn;
            delete.CommandText = "DROP TABLE " + tableName;
            delete.ExecuteNonQuery();
            conn.Close();
            form1.getTables();
            form1.ShowPanel5();
            form1.clearGrid();
            this.Close();
        }
        private void saveLibrary_Click(object sender, EventArgs e)
        {
            form1.getTables();
            form1.getTableData(tableName);           
            this.Close();

        }

        private void renameTableButton_Click(object sender, EventArgs e)
        {
            renameTable rt = new renameTable(tableName, this);
            rt.Show();
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
    }
}
