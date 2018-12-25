namespace LibYourself
{
    partial class renameTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableName = new System.Windows.Forms.Label();
            this.saveTableName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(188, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 35);
            this.textBox1.TabIndex = 0;
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableName.Location = new System.Drawing.Point(12, 59);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(154, 29);
            this.tableName.TabIndex = 1;
            this.tableName.Text = "New Name : ";
            // 
            // saveTableName
            // 
            this.saveTableName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveTableName.Location = new System.Drawing.Point(573, 50);
            this.saveTableName.Name = "saveTableName";
            this.saveTableName.Size = new System.Drawing.Size(131, 46);
            this.saveTableName.TabIndex = 2;
            this.saveTableName.Text = "Save";
            this.saveTableName.UseVisualStyleBackColor = true;
            this.saveTableName.Click += new System.EventHandler(this.saveTableName_Click);
            // 
            // renameTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 151);
            this.Controls.Add(this.saveTableName);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.textBox1);
            this.Name = "renameTable";
            this.Text = "New Library Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tableName;
        private System.Windows.Forms.Button saveTableName;
    }
}