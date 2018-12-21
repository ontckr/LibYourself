using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibYourself
{
    public partial class Form1 : Form
    {
        String selectedTable;

        public Form1()
        {
            InitializeComponent();
            getTables();
        }

        private void addNewLibrary_Click(object sender, EventArgs e)
        {
            addLibrary add = new addLibrary(this);
            add.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void searchKey_TextChanged(object sender, EventArgs e)
        {

        }
        private void showFavorite_Click(object sender, EventArgs e)
        {

        }
        private void deleteItem_Click(object sender, EventArgs e)
        {

        }
        private void editItem_Click(object sender, EventArgs e)
        {

        }
        // Get Tables From Database and List them
        public void getTables()
        {
            flowLayoutPanel1.Controls.Clear();


            using (SQLiteConnection connect = new SQLiteConnection("Data Source=DataTable.db;"))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY name";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        Console.WriteLine(r["name"]);
                        Button button = new Button();
                        button.Text = r["name"].ToString();
                        button.Width = 150;
                        button.Height = 40;

                        // Get the table name from button and pass it to another function to get the data
                        button.Click += (s, e) => {
                            //getTableName(tableName)
                            selectedTable = button.Text;
                            getTableData(button.Text);
                        };
                        flowLayoutPanel1.Controls.Add(button);
                    }
                }
            }
        }

        //Get the data from the table and add it to dataGrid
        public void getTableData(String tableName)
        {
            dataGridView1.Controls.Clear();
            
            using (SQLiteConnection connect = new SQLiteConnection("Data Source=DataTable.db;"))
            {
                connect.Open();
                DataSet dataSet = new DataSet();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("Select * From " + tableName, connect);
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            addItem addForm = new addItem(selectedTable);
            addForm.Show();
        }

        private void addFavorite_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
