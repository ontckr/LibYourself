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
using System.Collections;

namespace LibYourself
{
    public partial class Form1 : Form
    {
        ArrayList list = new ArrayList();
        ArrayList favList = new ArrayList();
        public String selectedTable;
        string tempName; 

        public Form1()
        {
            InitializeComponent();
            getTables();

            panel4.Hide();
            panel5.Hide();

            if (selectedTable == null)
            {
                panel5.Show();
            }
        }
        public void ShowPanel5()
        {
            panel4.Hide();
            panel5.Show();
        }
        public void ShowPanel4()
        {
            panel5.Hide();
            panel4.Show();
        }
        public void clearGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void addNewLibrary_Click(object sender, EventArgs e)
        {
            addLibrary add = new addLibrary(this);
            add.Show();
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
                        Font f = new Font("Arial", 10, FontStyle.Bold);
                        button.Font = f;
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
            panel5.Hide();
            panel4.Show();

            dataGridView1.Controls.Clear();

            using (SQLiteConnection connect = new SQLiteConnection("Data Source=DataTable.db;"))
            {
                connect.Open();
                DataSet dataSet = new DataSet();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("Select * From " + tableName, connect);
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;


                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dataGridView1.BackgroundColor = Color.White;

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            addItem addForm = new addItem(selectedTable, getTableAttributes(), this);
            addForm.Show();
        }
   
        private void editLibrary_Click(object sender, EventArgs e)
        {
            editLibrary form = new editLibrary(selectedTable,getTableAttributes(),this);
            form.Show();
        }
        // attribute list 
        private List<String> getTableAttributes() 
        {
            List<String> attributes = new List<string>();

            using (SQLiteConnection connect = new SQLiteConnection("Data Source=DataTable.db;"))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = "PRAGMA table_info(" + selectedTable + ")";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        attributes.Add(r["name"].ToString());
                    }
                }
            }
            return attributes;
        }

        /*private void addFavorite_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Favorites.db;");
            conn.Open();

            SQLiteCommand addFav = new SQLiteCommand();
            addFav.Connection = conn;


            foreach (DataGridViewCell row in dataGridView1.SelectedCells)
            {


                string row_1 = dataGridView1.CurrentCell.Value.ToString();
                favList.Add(dataGridView1.CurrentCell.Value.ToString());
                Console.WriteLine(favList[0]);
                addFav.CommandText = "INSERT INTO favorites (favorite) VALUES ('" + row_1 + "')";
                addFav.ExecuteNonQuery();
                MessageBox.Show("Selected Item Added into Favorites !");



            }

        }*/

        
        
        private void searchButton_Click(object sender, EventArgs e)
        {

        }
        private void searchKey_TextChanged(object sender, EventArgs e)
        {
           
        }

       /* private void showFavorite_Click(object sender, EventArgs e)
        {

            panel5.Hide();
            panel4.Show();

            dataGridView1.Controls.Clear();

            using (SQLiteConnection connect = new SQLiteConnection("Data Source=Favorites.db;"))
            {
                connect.Open();
                DataSet dataSet = new DataSet();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("Select * From favorites", connect);
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }

        }*/

         private void deleteItem_Click(object sender, EventArgs e)
        {
            //SQLiteConnection conn = new SQLiteConnection("Data Source=Favorites.db;");
            SQLiteConnection connect = new SQLiteConnection("Data Source=DataTable.db;");
            connect.Open();
            //conn.Open();
            SQLiteCommand del = new SQLiteCommand();
            SQLiteCommand com = new SQLiteCommand();


            List<String> attributes = new List<string>();
            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = "PRAGMA table_info(" + selectedTable + ")";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    attributes.Add(r["name"].ToString());
                }
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                   // list.Clear();
                   // for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                   // { list.Add(dataGridView1.SelectedRows[0].Cells[i].Value.ToString()); }
                   // foreach (string a in list)
                   // {
                   //     foreach (string b in favList)
                   //     {
                   //         if (a == b) { tempName = b; }
                   //     }

                   // }

                    string row_1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                    del.CommandText = "DELETE FROM " + selectedTable + " WHERE " + attributes[0] + "= '" + row_1 + "'";

                   // com.CommandText = "DELETE FROM favorites WHERE favorite = '" + tempName + "'";
                    del.Connection = connect;
                   // com.Connection = conn;
                    del.ExecuteNonQuery();
                  //  com.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(row.Index);
                   // favList.Remove(tempName);
                }
                else
                {
                    MessageBox.Show("You Can Select Only One Row For Deleting !");
                    break;
                }

            }







        }
        private void editItem_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel4.Show();
            dataGridView1.Controls.Clear();
            SQLiteConnection connect = new SQLiteConnection("Data Source=DataTable.db;");
            connect.Open();
            List<String> attributes = new List<string>();
            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = "PRAGMA table_info(" + selectedTable + ")";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    attributes.Add(r["name"].ToString());
                }
            }


            string search = searchKey.Text;

            DataSet dataSet = new DataSet();
            foreach (string sk in attributes)
            {

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM " + selectedTable + " WHERE " + sk + "= '" + search + "'", connect);

                dataAdapter.Fill(dataSet);



            }
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView;





        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Favorites.db;");
            conn.Open();
            SQLiteCommand delFav = new SQLiteCommand();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {

                    string row_1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


                    delFav.CommandText = "DELETE FROM favorites WHERE favorite = '" + row_1 + "'";
                    delFav.Connection = conn;

                    delFav.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(row.Index);
                    favList.Remove(tempName);
                }
                else
                {
                    MessageBox.Show("You Can Select Only One Row For Deleting !");
                    break;
                }

            }
        }*/
    }
}
