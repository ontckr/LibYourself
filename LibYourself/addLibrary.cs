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
using System.Data.SqlClient;
namespace LibYourself
{
    public partial class addLibrary : Form
    {
        public addLibrary()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createLibrary_Click(object sender, EventArgs e)
        {

            SQLiteConnection conn = new SQLiteConnection
            {
                ConnectionString = ("Data Source=C:/Users/Cemal Çağatay Buvan/Desktop/LibYourself/LibYourself/database/DataTable.db")
            };
            conn.Open();
            SQLiteCommand create = new SQLiteCommand();
            SQLiteCommand att = new SQLiteCommand();
            create.Connection = conn;
            create.CommandText = "Create Table " + libraryName.Text + "(" + listBox1.Items[0] + " TEXT)";
            create.ExecuteNonQuery();
            listBox1.Items.RemoveAt(0);
            att.Connection = conn;



            foreach (string ColumnName in listBox1.Items)
            {

                att.CommandText = "ALTER TABLE " + libraryName.Text + " ADD COLUMN " + ColumnName + " TEXT ";
                att.ExecuteNonQuery();

            }



        }

        private void addLibrary_Load(object sender, EventArgs e)
        {

        }


        private void addAttributeButton_Click_1(object sender, EventArgs e)
        {
            if (this.newAttribute.Text != "")
            {
                listBox1.Items.Add(this.newAttribute.Text);
                this.newAttribute.Focus();
                this.newAttribute.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an attribute name to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.newAttribute.Focus();
            }
        }

        private void deleteAttributeButton_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
        }

        private void libraryName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
