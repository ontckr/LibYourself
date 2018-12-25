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
            this.libraryName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.libraryName.Location = new System.Drawing.Point(158, 71);
            this.libraryName.Name = "libraryName";
            this.libraryName.Size = new System.Drawing.Size(276, 38);
            this.libraryName.TabIndex = 0;
            this.libraryName.Text = "";
            // 
            // newAttribute
            // 
            this.newAttribute.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newAttribute.Location = new System.Drawing.Point(158, 138);
            this.newAttribute.Name = "newAttribute";
            this.newAttribute.Size = new System.Drawing.Size(276, 36);
            this.newAttribute.TabIndex = 1;
            this.newAttribute.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Attribute : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(158, 212);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 301);
            this.listBox1.TabIndex = 4;
            // 
            // addAttributeButton
            // 
            this.addAttributeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addAttributeButton.Location = new System.Drawing.Point(458, 130);
            this.addAttributeButton.Name = "addAttributeButton";
            this.addAttributeButton.Size = new System.Drawing.Size(128, 50);
            this.addAttributeButton.TabIndex = 5;
            this.addAttributeButton.Text = "Add";
            this.addAttributeButton.UseVisualStyleBackColor = true;
            this.addAttributeButton.Click += new System.EventHandler(this.addAttributeButton_Click_1);
            // 
            // deleteAttributeButton
            // 
            this.deleteAttributeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteAttributeButton.Location = new System.Drawing.Point(458, 325);
            this.deleteAttributeButton.Name = "deleteAttributeButton";
            this.deleteAttributeButton.Size = new System.Drawing.Size(128, 50);
            this.deleteAttributeButton.TabIndex = 6;
            this.deleteAttributeButton.Text = "Delete";
            this.deleteAttributeButton.UseVisualStyleBackColor = true;
            this.deleteAttributeButton.Click += new System.EventHandler(this.deleteAttributeButton_Click_1);
            // 
            // createLibrary
            // 
            this.createLibrary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createLibrary.Location = new System.Drawing.Point(458, 552);
            this.createLibrary.Name = "createLibrary";
            this.createLibrary.Size = new System.Drawing.Size(128, 50);
            this.createLibrary.TabIndex = 7;
            this.createLibrary.Text = "Create";
            this.createLibrary.UseVisualStyleBackColor = true;
            this.createLibrary.Click += new System.EventHandler(this.createLibrary_Click);
            // 
            // addLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 626);
            this.Controls.Add(this.createLibrary);
            this.Controls.Add(this.deleteAttributeButton);
            this.Controls.Add(this.addAttributeButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newAttribute);
            this.Controls.Add(this.libraryName);
            this.Name = "addLibrary";
            this.Text = "New Library";
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