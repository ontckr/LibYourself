using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibYourself
{
    public partial class renameTable : Form
    {
        private String currentTableName;
        private editLibrary editLibrary;

        public renameTable(String currentTableName, editLibrary editLibrary)
        {
            InitializeComponent();
            this.currentTableName = currentTableName;
            this.editLibrary = editLibrary;
        }

        private void saveTableName_Click(object sender, EventArgs e)
        {
           if(textBox1.Text != "")
            {
                SQLiteConnection conn = new SQLiteConnection
                {
                    ConnectionString = ("Data Source=DataTable.db;")
                };

                conn.Open();
                SQLiteCommand rename = new SQLiteCommand();
                rename.Connection = conn;

                if (currentTableName == textBox1.Text)
                    MessageBox.Show("Please Rename The library name");
                else
                {

                    rename.CommandText = "ALTER TABLE " + currentTableName + " RENAME TO " + textBox1.Text;
                    rename.ExecuteNonQuery();

                    editLibrary.tableName = textBox1.Text;

                }
                conn.Close();
                this.Close();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("burayı boş bırakamazsınız", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
            
        }
    }
}
