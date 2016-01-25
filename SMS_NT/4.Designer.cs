namespace SMS_NT
{
    partial class _4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Remove_Product_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PnameComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Quan_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Unit_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Remove_Product_Button
            // 
            this.Remove_Product_Button.Location = new System.Drawing.Point(70, 295);
            this.Remove_Product_Button.Name = "Remove_Product_Button";
            this.Remove_Product_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Product_Button.TabIndex = 3;
            this.Remove_Product_Button.Text = "Remove";
            this.Remove_Product_Button.UseVisualStyleBackColor = true;
            this.Remove_Product_Button.Click += new System.EventHandler(this.Remove_Product_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Update Product";
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(238, 295);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 7;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Name : ";
            // 
            // PnameComboBox
            // 
            this.PnameComboBox.FormattingEnabled = true;
            this.PnameComboBox.Location = new System.Drawing.Point(160, 112);
            this.PnameComboBox.Name = "PnameComboBox";
            this.PnameComboBox.Size = new System.Drawing.Size(121, 21);
            this.PnameComboBox.TabIndex = 5;
            this.PnameComboBox.SelectedIndexChanged += new System.EventHandler(this.PnameComboBox_SelectedIndexChanged);
            this.PnameComboBox.Click += new System.EventHandler(this.PnameComboBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity : ";
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(160, 144);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(118, 20);
            this.Price_textBox.TabIndex = 11;
            // 
            // Quan_textBox
            // 
            this.Quan_textBox.Location = new System.Drawing.Point(160, 177);
            this.Quan_textBox.Name = "Quan_textBox";
            this.Quan_textBox.Size = new System.Drawing.Size(118, 20);
            this.Quan_textBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Unit :";
            // 
            // Unit_textBox
            // 
            this.Unit_textBox.Location = new System.Drawing.Point(160, 209);
            this.Unit_textBox.Name = "Unit_textBox";
            this.Unit_textBox.Size = new System.Drawing.Size(118, 20);
            this.Unit_textBox.TabIndex = 14;
            // 
            // _4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Unit_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quan_textBox);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PnameComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Remove_Product_Button);
            this.Name = "_4";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Remove_Product_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PnameComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.TextBox Quan_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Unit_textBox;
    }
}
