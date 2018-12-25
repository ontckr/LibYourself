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
    public partial class addItem : Form
    {
         
        public String tableName;
        private List<String> attributeList;
        private Form1 mainForm;

        SQLiteConnection conn = new SQLiteConnection
        {
            ConnectionString = ("Data Source=DataTable.db;")
        };

        public addItem(String tableName, List<String> attributeList, Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tableName = tableName;
            this.attributeList = attributeList;
            conn.Open();
            fillTable();
        }

        public void fillTable()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = attributeList.Count;

            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            for (int i=0;i<attributeList.Count;i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute,50f));

                Label attributeName = new Label();
                attributeName.Text = (attributeList[i] +" : ");
                attributeName.TextAlign = ContentAlignment.MiddleRight;
                attributeName.Font = new Font("Arial", 14, FontStyle.Bold);
                attributeName.Anchor = (AnchorStyles.Left | AnchorStyles.Right);

                tableLayoutPanel1.Controls.Add(attributeName,0,i);
                
                TextBox textBox = new TextBox();

                textBox.Tag = attributeList[i];
                
                textBox.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                textBox.AutoSize = false;
                textBox.Size = new System.Drawing.Size(228, 25);
                textBox.Font = new Font("Arial", 12);

                tableLayoutPanel1.Controls.Add(textBox,1,i);             
            }

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(new Label(), 0, attributeList.Count);
            tableLayoutPanel1.Controls.Add(new Label(), 1, attributeList.Count);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection sQLite = new SQLiteConnection
            {
                ConnectionString = ("Data Source=DataTable.db;")
            };
            String attributeString = "";
            foreach (string attribute in attributeList)
            {
                attributeString += attribute + ",";
            }
            attributeString = attributeString.Remove(attributeString.Length - 1);

            String valuesString = "";
            for (int i = 0; i < attributeList.Count; i++)
            {
                TextBox textBox = tableLayoutPanel1.GetControlFromPosition(1, i) as TextBox;
                valuesString += '"'+textBox.Text+'"' + ",";
            }

            valuesString = valuesString.Remove(valuesString.Length - 1);

            sQLite.Open();
            SQLiteCommand addColumn = new SQLiteCommand();
            addColumn.Connection = sQLite;
            addColumn.CommandText = "INSERT INTO "+ tableName +" (" + attributeString + ") VALUES (" + valuesString + ");";
            addColumn.ExecuteNonQuery();
            sQLite.Close();
            mainForm.getTableData(tableName);
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void attribute_Click(object sender, EventArgs e){}
    }
}
