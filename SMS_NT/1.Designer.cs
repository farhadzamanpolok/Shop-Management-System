namespace SMS_NT
{
    partial class _1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_inventory_button = new System.Windows.Forms.Button();
            this.pname_tbox = new System.Windows.Forms.TextBox();
            this.Pprice_tbox = new System.Windows.Forms.TextBox();
            this.Pavailable_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Unit_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available :";
            // 
            // Add_inventory_button
            // 
            this.Add_inventory_button.Location = new System.Drawing.Point(165, 282);
            this.Add_inventory_button.Name = "Add_inventory_button";
            this.Add_inventory_button.Size = new System.Drawing.Size(75, 23);
            this.Add_inventory_button.TabIndex = 4;
            this.Add_inventory_button.Text = "Add";
            this.Add_inventory_button.UseVisualStyleBackColor = true;
            this.Add_inventory_button.Click += new System.EventHandler(this.Add_inventory_button_Click);
            // 
            // pname_tbox
            // 
            this.pname_tbox.Location = new System.Drawing.Point(149, 122);
            this.pname_tbox.Name = "pname_tbox";
            this.pname_tbox.Size = new System.Drawing.Size(141, 20);
            this.pname_tbox.TabIndex = 5;
            // 
            // Pprice_tbox
            // 
            this.Pprice_tbox.Location = new System.Drawing.Point(149, 157);
            this.Pprice_tbox.Name = "Pprice_tbox";
            this.Pprice_tbox.Size = new System.Drawing.Size(141, 20);
            this.Pprice_tbox.TabIndex = 6;
            // 
            // Pavailable_tbox
            // 
            this.Pavailable_tbox.Location = new System.Drawing.Point(149, 198);
            this.Pavailable_tbox.Name = "Pavailable_tbox";
            this.Pavailable_tbox.Size = new System.Drawing.Size(141, 20);
            this.Pavailable_tbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit :";
            // 
            // Unit_textBox
            // 
            this.Unit_textBox.Location = new System.Drawing.Point(149, 235);
            this.Unit_textBox.Name = "Unit_textBox";
            this.Unit_textBox.Size = new System.Drawing.Size(141, 20);
            this.Unit_textBox.TabIndex = 9;
            // 
            // _1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Unit_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pavailable_tbox);
            this.Controls.Add(this.Pprice_tbox);
            this.Controls.Add(this.pname_tbox);
            this.Controls.Add(this.Add_inventory_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_1";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_inventory_button;
        private System.Windows.Forms.TextBox pname_tbox;
        private System.Windows.Forms.TextBox Pprice_tbox;
        private System.Windows.Forms.TextBox Pavailable_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Unit_textBox;
    }
}
