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
        SQLiteConnection conn = new SQLiteConnection
        {
            ConnectionString = ("Data Source=DataTable.db;")
        };
        

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
                    conn.Open();
                    SQLiteCommand addColumn = new SQLiteCommand();
                    addColumn.Connection = conn;
                    addColumn.CommandText = "ALTER TABLE " + editLibraryName.Text + " ADD COLUMN " + editNewAttribute.Text;
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
                conn.Open();
                SQLiteCommand deleteColumn = new SQLiteCommand();
                deleteColumn.Connection = conn;
                deleteColumn.CommandText = "Create Table Virtual (" + listBox1.Items[0] + " TEXT)";
                deleteColumn.ExecuteNonQuery();
                SQLiteCommand virtualization = new SQLiteCommand();
                SQLiteCommand virtualizationEntity= new SQLiteCommand();
                virtualization.Connection = conn;
                virtualizationEntity.Connection = conn;
            foreach (string ColumnName in listBox1.Items)
            {
                if (ColumnName == listBox1.Items[0].ToString())
                 continue; 
                 virtualization.CommandText = "ALTER TABLE Virtual ADD COLUMN " + ColumnName + " TEXT ";
                 virtualization.ExecuteNonQuery();
                
                
            }

            foreach (string Entity in listBox1.Items)
            {

                virtualizationEntity.CommandText = "INSERT INTO Virtual (" + Entity + ") SELECT " + Entity + " FROM " + editLibraryName.Text;
                virtualizationEntity.ExecuteNonQuery();

            }
            

                SQLiteCommand deleteReal = new SQLiteCommand();
                deleteReal.Connection = conn;
                deleteReal.CommandText = "DROP TABLE " + editLibraryName.Text;
                deleteReal.ExecuteNonQuery();
                SQLiteCommand renameVirtual = new SQLiteCommand();
                renameVirtual.Connection = conn;
                renameVirtual.CommandText = "ALTER TABLE Virtual RENAME TO " + editLibraryName.Text;
                renameVirtual.ExecuteNonQuery();
                conn.Close();
            

        }
        
        private void deleteLibrary_Click(object sender, EventArgs e)
        {
            
                conn.Open();
                SQLiteCommand delete = new SQLiteCommand();
                delete.Connection = conn;
                delete.CommandText = "DROP TABLE " + editLibraryName.Text;
                delete.ExecuteNonQuery();
                conn.Close();
                this.Close();




        }

        private void saveLibrary_Click(object sender, EventArgs e)
        {
            

        }

        private void renameTableButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SQLiteCommand rename = new SQLiteCommand();
            rename.Connection = conn;
            if (this.tableName == editLibraryName.Text)
                MessageBox.Show("Please Rename The library name");
            else
            {
                rename.CommandText = "ALTER TABLE " + this.tableName + " RENAME TO " + editLibraryName.Text;
                rename.ExecuteNonQuery();

            }

            conn.Close();
        }
    }
}
