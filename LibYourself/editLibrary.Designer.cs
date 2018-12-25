namespace LibYourself
{
    partial class editLibrary
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
            this.deleteLibrary = new System.Windows.Forms.Button();
            this.saveLibrary = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.editDeleteAttribute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editNewAttribute = new System.Windows.Forms.RichTextBox();
            this.editAddButton = new System.Windows.Forms.Button();
            this.renameTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteLibrary
            // 
            this.deleteLibrary.BackColor = System.Drawing.Color.LightCoral;
            this.deleteLibrary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteLibrary.Location = new System.Drawing.Point(72, 448);
            this.deleteLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteLibrary.Name = "deleteLibrary";
            this.deleteLibrary.Size = new System.Drawing.Size(206, 55);
            this.deleteLibrary.TabIndex = 0;
            this.deleteLibrary.Text = "Delete Library";
            this.deleteLibrary.UseVisualStyleBackColor = false;
            this.deleteLibrary.Click += new System.EventHandler(this.deleteLibrary_Click);
            // 
            // saveLibrary
            // 
            this.saveLibrary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveLibrary.Location = new System.Drawing.Point(405, 532);
            this.saveLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveLibrary.Name = "saveLibrary";
            this.saveLibrary.Size = new System.Drawing.Size(180, 55);
            this.saveLibrary.TabIndex = 1;
            this.saveLibrary.Text = "Close";
            this.saveLibrary.UseVisualStyleBackColor = true;
            this.saveLibrary.Click += new System.EventHandler(this.saveLibrary_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(153, 114);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 274);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // editDeleteAttribute
            // 
            this.editDeleteAttribute.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editDeleteAttribute.Location = new System.Drawing.Point(457, 209);
            this.editDeleteAttribute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editDeleteAttribute.Name = "editDeleteAttribute";
            this.editDeleteAttribute.Size = new System.Drawing.Size(128, 50);
            this.editDeleteAttribute.TabIndex = 3;
            this.editDeleteAttribute.Text = "Delete";
            this.editDeleteAttribute.UseVisualStyleBackColor = true;
            this.editDeleteAttribute.Click += new System.EventHandler(this.editDeleteAttribute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Attribute : ";
            // 
            // editNewAttribute
            // 
            this.editNewAttribute.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editNewAttribute.Location = new System.Drawing.Point(153, 49);
            this.editNewAttribute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editNewAttribute.Name = "editNewAttribute";
            this.editNewAttribute.Size = new System.Drawing.Size(276, 36);
            this.editNewAttribute.TabIndex = 7;
            this.editNewAttribute.Text = "";
            this.editNewAttribute.TextChanged += new System.EventHandler(this.editNewAttribute_TextChanged);
            // 
            // editAddButton
            // 
            this.editAddButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editAddButton.Location = new System.Drawing.Point(457, 44);
            this.editAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editAddButton.Name = "editAddButton";
            this.editAddButton.Size = new System.Drawing.Size(128, 50);
            this.editAddButton.TabIndex = 8;
            this.editAddButton.Text = "Add";
            this.editAddButton.UseVisualStyleBackColor = true;
            this.editAddButton.Click += new System.EventHandler(this.editAddButton_Click);
            // 
            // renameTableButton
            // 
            this.renameTableButton.BackColor = System.Drawing.Color.Bisque;
            this.renameTableButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.renameTableButton.Location = new System.Drawing.Point(72, 532);
            this.renameTableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.renameTableButton.Name = "renameTableButton";
            this.renameTableButton.Size = new System.Drawing.Size(206, 55);
            this.renameTableButton.TabIndex = 9;
            this.renameTableButton.Text = "Rename Library";
            this.renameTableButton.UseVisualStyleBackColor = false;
            this.renameTableButton.Click += new System.EventHandler(this.renameTableButton_Click);
            // 
            // editLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 614);
            this.Controls.Add(this.renameTableButton);
            this.Controls.Add(this.editAddButton);
            this.Controls.Add(this.editNewAttribute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editDeleteAttribute);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.saveLibrary);
            this.Controls.Add(this.deleteLibrary);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editLibrary";
            this.Text = "Edit Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteLibrary;
        private System.Windows.Forms.Button saveLibrary;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button editDeleteAttribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox editNewAttribute;
        private System.Windows.Forms.Button editAddButton;
        private System.Windows.Forms.Button renameTableButton;
    }
}