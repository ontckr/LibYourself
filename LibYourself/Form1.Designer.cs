namespace LibYourself
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addNewLibrary = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editLibrary = new System.Windows.Forms.Button();
            this.addFavorite = new System.Windows.Forms.Button();
            this.searchKey = new System.Windows.Forms.RichTextBox();
            this.showFavorite = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.editItem = new System.Windows.Forms.Button();
            this.deleteItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 996);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 131);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 865);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.addNewLibrary);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 131);
            this.panel3.TabIndex = 0;
            // 
            // addNewLibrary
            // 
            this.addNewLibrary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewLibrary.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNewLibrary.Location = new System.Drawing.Point(23, 24);
            this.addNewLibrary.Name = "addNewLibrary";
            this.addNewLibrary.Size = new System.Drawing.Size(200, 83);
            this.addNewLibrary.TabIndex = 0;
            this.addNewLibrary.Text = "New Library";
            this.addNewLibrary.UseVisualStyleBackColor = false;
            this.addNewLibrary.Click += new System.EventHandler(this.addNewLibrary_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 996);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Bisque;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1227, 1196);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1051, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bu bir kişisel kütühane uygulamasıdır......... /ekstra tanım/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1197, 300);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Courier New", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(279, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 128);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome LibYourself\r\n\r";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 865);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.editLibrary);
            this.panel4.Controls.Add(this.addFavorite);
            this.panel4.Controls.Add(this.searchKey);
            this.panel4.Controls.Add(this.showFavorite);
            this.panel4.Controls.Add(this.searchButton);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.editItem);
            this.panel4.Controls.Add(this.deleteItem);
            this.panel4.Controls.Add(this.addItem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1227, 131);
            this.panel4.TabIndex = 0;
            // 
            // editLibrary
            // 
            this.editLibrary.BackColor = System.Drawing.SystemColors.Info;
            this.editLibrary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editLibrary.Location = new System.Drawing.Point(28, 23);
            this.editLibrary.Name = "editLibrary";
            this.editLibrary.Size = new System.Drawing.Size(190, 80);
            this.editLibrary.TabIndex = 1;
            this.editLibrary.Text = "Edit Library";
            this.editLibrary.UseVisualStyleBackColor = false;
            this.editLibrary.Click += new System.EventHandler(this.editLibrary_Click);
            // 
            // addFavorite
            // 
            this.addFavorite.BackColor = System.Drawing.Color.MintCream;
            this.addFavorite.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addFavorite.Location = new System.Drawing.Point(653, 68);
            this.addFavorite.Name = "addFavorite";
            this.addFavorite.Size = new System.Drawing.Size(193, 50);
            this.addFavorite.TabIndex = 10;
            this.addFavorite.Text = "Add Favorite";
            this.addFavorite.UseVisualStyleBackColor = false;
            this.addFavorite.Click += new System.EventHandler(this.addFavorite_Click);
            // 
            // searchKey
            // 
            this.searchKey.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchKey.Location = new System.Drawing.Point(878, 20);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(320, 38);
            this.searchKey.TabIndex = 9;
            this.searchKey.Text = "";
            this.searchKey.TextChanged += new System.EventHandler(this.searchKey_TextChanged);
            // 
            // showFavorite
            // 
            this.showFavorite.BackColor = System.Drawing.Color.PaleTurquoise;
            this.showFavorite.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showFavorite.Location = new System.Drawing.Point(653, 12);
            this.showFavorite.Name = "showFavorite";
            this.showFavorite.Size = new System.Drawing.Size(193, 50);
            this.showFavorite.TabIndex = 8;
            this.showFavorite.Text = "Favorites";
            this.showFavorite.UseVisualStyleBackColor = false;
            this.showFavorite.Click += new System.EventHandler(this.showFavorite_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.Location = new System.Drawing.Point(1092, 71);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(107, 44);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(878, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 35);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // editItem
            // 
            this.editItem.BackColor = System.Drawing.SystemColors.Info;
            this.editItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editItem.Location = new System.Drawing.Point(469, 68);
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(161, 50);
            this.editItem.TabIndex = 2;
            this.editItem.Text = "Edit Item";
            this.editItem.UseVisualStyleBackColor = false;
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.BackColor = System.Drawing.Color.LightCoral;
            this.deleteItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteItem.Location = new System.Drawing.Point(469, 12);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(161, 50);
            this.deleteItem.TabIndex = 1;
            this.deleteItem.Text = "Delete Item";
            this.deleteItem.UseVisualStyleBackColor = false;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // addItem
            // 
            this.addItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addItem.Location = new System.Drawing.Point(269, 24);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(152, 79);
            this.addItem.TabIndex = 0;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = false;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 996);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "LibYourself";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addNewLibrary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button editLibrary;
        private System.Windows.Forms.Button addFavorite;
        private System.Windows.Forms.RichTextBox searchKey;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button editItem;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button showFavorite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

