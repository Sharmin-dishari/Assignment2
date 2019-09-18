namespace CoffeShop
{
    partial class CoffeShop
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
            this.CoffeGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OrderComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CusNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.CoffeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CoffeGroupBox
            // 
            this.CoffeGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CoffeGroupBox.Controls.Add(this.ShowButton);
            this.CoffeGroupBox.Controls.Add(this.PriceComboBox);
            this.CoffeGroupBox.Controls.Add(this.label6);
            this.CoffeGroupBox.Controls.Add(this.totallabel);
            this.CoffeGroupBox.Controls.Add(this.SaveButton);
            this.CoffeGroupBox.Controls.Add(this.QuantityNumericUpDown);
            this.CoffeGroupBox.Controls.Add(this.OrderComboBox);
            this.CoffeGroupBox.Controls.Add(this.label5);
            this.CoffeGroupBox.Controls.Add(this.label4);
            this.CoffeGroupBox.Controls.Add(this.AdressTextBox);
            this.CoffeGroupBox.Controls.Add(this.label3);
            this.CoffeGroupBox.Controls.Add(this.ContactTextBox);
            this.CoffeGroupBox.Controls.Add(this.label2);
            this.CoffeGroupBox.Controls.Add(this.CusNameTextBox);
            this.CoffeGroupBox.Controls.Add(this.label1);
            this.CoffeGroupBox.Location = new System.Drawing.Point(40, 37);
            this.CoffeGroupBox.Name = "CoffeGroupBox";
            this.CoffeGroupBox.Size = new System.Drawing.Size(381, 383);
            this.CoffeGroupBox.TabIndex = 0;
            this.CoffeGroupBox.TabStop = false;
            this.CoffeGroupBox.Text = "Customer Information";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(224, 309);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 16;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Regular-80"});
            this.PriceComboBox.Location = new System.Drawing.Point(124, 162);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(121, 21);
            this.PriceComboBox.TabIndex = 15;
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price List";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Location = new System.Drawing.Point(299, 87);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(0, 13);
            this.totallabel.TabIndex = 13;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(135, 309);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(124, 255);
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.QuantityNumericUpDown.TabIndex = 11;
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Items.AddRange(new object[] {
            "120",
            "100",
            "90",
            "80"});
            this.OrderComboBox.Location = new System.Drawing.Point(124, 211);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(121, 21);
            this.OrderComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(124, 118);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(121, 20);
            this.AdressTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(124, 80);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(121, 20);
            this.ContactTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact No.";
            // 
            // CusNameTextBox
            // 
            this.CusNameTextBox.Location = new System.Drawing.Point(124, 36);
            this.CusNameTextBox.Name = "CusNameTextBox";
            this.CusNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.CusNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(482, 37);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(248, 332);
            this.RichTextBox.TabIndex = 1;
            this.RichTextBox.Text = "";
            this.RichTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // CoffeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.CoffeGroupBox);
            this.Name = "CoffeShop";
            this.Text = "Coffe Shop";
            this.CoffeGroupBox.ResumeLayout(false);
            this.CoffeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CoffeGroupBox;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.ComboBox OrderComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CusNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ShowButton;
    }
}

