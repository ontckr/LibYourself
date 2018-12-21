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
            addLibrary add = new addLibrary();
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

            for(int i = 0; i<5; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Width = 150;
                button.Height = 40;

                // Get the table name from button and pass it to another function to get the data
                button.Click += (s, e) => {
                    //getTableName(tableName)
                    selectedTable = "Books";
                };
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        //Get the data from the table and add it to dataGrid
        public void getTableData(String tableName)
        {
            dataGridView1.Controls.Clear();
            // For each record that is coming from the table, add to datagrid
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            addItem addForm = new addItem(selectedTable);
            addForm.Show();
        }

        private void addFavorite_Click(object sender, EventArgs e)
        {

        }
    }
}
