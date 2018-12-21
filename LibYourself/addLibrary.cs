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
        private Form1 form1;
        public addLibrary(Form1 f1)
        {
            InitializeComponent();
            this.form1 = f1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deleteAttributeButton_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }

        SQLiteConnection conn = new SQLiteConnection
        {
            ConnectionString = ("Data Source=DataTable.db;")
        };

        private void createLibrary_Click(object sender, EventArgs e)
        {

           
            conn.Open();
            SQLiteCommand create = new SQLiteCommand();
            SQLiteCommand att = new SQLiteCommand();
            create.Connection = conn;
            if(libraryName.Text != "" || listBox1.Text !=""){
                create.CommandText = "Create Table " + libraryName.Text + "(" + listBox1.Items[0] + " TEXT)";
                create.ExecuteNonQuery();
            }
            else if (libraryName.Text == "")
            {
                MessageBox.Show("Please enter a library name to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.newAttribute.Focus();
                return;
            }
            else if (listBox1.Text == "")
            {
                MessageBox.Show("tablo yaratmak için lütfen en az 1 attr. girin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            listBox1.Items.RemoveAt(0);

            att.Connection = conn;

            foreach (string ColumnName in listBox1.Items)
            {
                Console.WriteLine(ColumnName);
                att.CommandText = "ALTER TABLE " + libraryName.Text + " ADD COLUMN " + ColumnName + " TEXT ";
                att.ExecuteNonQuery();

            }
            form1.getTables();
            form1.getTableData(libraryName.Text);
            this.Close();
        }

        private void addLibrary_Load(object sender, EventArgs e)
        {

        }

        Form1 obj = new Form1();

        private void addAttributeButton_Click_1(object sender, EventArgs e)
        {
            if (this.newAttribute.Text != "")
            {
                listBox1.Items.Add(this.newAttribute.Text);
                this.newAttribute.Focus();
                this.newAttribute.Clear();
            }
           
            else if (newAttribute.Text == "")
            {
                MessageBox.Show("burayı boş bırakamazsınız", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            obj.getTables();
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
