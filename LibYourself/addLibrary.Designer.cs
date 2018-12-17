namespace LibYourself
{
    partial class addLibrary
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
            this.libraryName = new System.Windows.Forms.RichTextBox();
            this.newAttribute = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addAttributeButton = new System.Windows.Forms.Button();
            this.deleteAttributeButton = new System.Windows.Forms.Button();
            this.createLibrary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // libraryName
            // 
            this.libraryName.Location = new System.Drawing.Point(105, 46);
            this.libraryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.libraryName.Name = "libraryName";
            this.libraryName.Size = new System.Drawing.Size(185, 26);
            this.libraryName.TabIndex = 0;
            this.libraryName.Text = "";
            // 
            // newAttribute
            // 
            this.newAttribute.Location = new System.Drawing.Point(105, 90);
            this.newAttribute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newAttribute.Name = "newAttribute";
            this.newAttribute.Size = new System.Drawing.Size(185, 25);
            this.newAttribute.TabIndex = 1;
            this.newAttribute.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Attribute : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(105, 138);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 225);
            this.listBox1.TabIndex = 4;
            // 
            // addAttributeButton
            // 
            this.addAttributeButton.Location = new System.Drawing.Point(299, 90);
            this.addAttributeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAttributeButton.Name = "addAttributeButton";
            this.addAttributeButton.Size = new System.Drawing.Size(69, 24);
            this.addAttributeButton.TabIndex = 5;
            this.addAttributeButton.Text = "Add";
            this.addAttributeButton.UseVisualStyleBackColor = true;
            this.addAttributeButton.Click += new System.EventHandler(this.addAttributeButton_Click_1);
            // 
            // deleteAttributeButton
            // 
            this.deleteAttributeButton.Location = new System.Drawing.Point(299, 225);
            this.deleteAttributeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteAttributeButton.Name = "deleteAttributeButton";
            this.deleteAttributeButton.Size = new System.Drawing.Size(69, 27);
            this.deleteAttributeButton.TabIndex = 6;
            this.deleteAttributeButton.Text = "Delete";
            this.deleteAttributeButton.UseVisualStyleBackColor = true;
            // 
            // createLibrary
            // 
            this.createLibrary.Location = new System.Drawing.Point(322, 359);
            this.createLibrary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createLibrary.Name = "createLibrary";
            this.createLibrary.Size = new System.Drawing.Size(76, 32);
            this.createLibrary.TabIndex = 7;
            this.createLibrary.Text = "Create";
            this.createLibrary.UseVisualStyleBackColor = true;
            this.createLibrary.Click += new System.EventHandler(this.createLibrary_Click);
            // 
            // addLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 399);
            this.Controls.Add(this.createLibrary);
            this.Controls.Add(this.deleteAttributeButton);
            this.Controls.Add(this.addAttributeButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newAttribute);
            this.Controls.Add(this.libraryName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addLibrary";
            this.Text = "addLibrary";
            this.Load += new System.EventHandler(this.addLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox libraryName;
        private System.Windows.Forms.RichTextBox newAttribute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addAttributeButton;
        private System.Windows.Forms.Button deleteAttributeButton;
        private System.Windows.Forms.Button createLibrary;
    }
}