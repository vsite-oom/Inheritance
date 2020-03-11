namespace Nasljeđivanje
{
    partial class FormMain
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFamilyName = new System.Windows.Forms.TextBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.textBoxPostcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxShippingPostcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxShippingTown = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxShippingAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxShippingFamilyName = new TextBoxWithDefault();
            this.textBoxShippingName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 40);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(88, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "First &name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(147, 35);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(223, 26);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Hrvoje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Family name:";
            // 
            // textBoxFamilyName
            // 
            this.textBoxFamilyName.Location = new System.Drawing.Point(147, 80);
            this.textBoxFamilyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFamilyName.Name = "textBoxFamilyName";
            this.textBoxFamilyName.Size = new System.Drawing.Size(223, 26);
            this.textBoxFamilyName.TabIndex = 3;
            this.textBoxFamilyName.Text = "Horvat";
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.textBoxPostcode);
            this.groupBoxCustomer.Controls.Add(this.label4);
            this.groupBoxCustomer.Controls.Add(this.textBoxTown);
            this.groupBoxCustomer.Controls.Add(this.label3);
            this.groupBoxCustomer.Controls.Add(this.textBoxStreet);
            this.groupBoxCustomer.Controls.Add(this.label2);
            this.groupBoxCustomer.Controls.Add(this.labelName);
            this.groupBoxCustomer.Controls.Add(this.textBoxFamilyName);
            this.groupBoxCustomer.Controls.Add(this.textBoxName);
            this.groupBoxCustomer.Controls.Add(this.label1);
            this.groupBoxCustomer.Location = new System.Drawing.Point(18, 18);
            this.groupBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCustomer.Size = new System.Drawing.Size(381, 274);
            this.groupBoxCustomer.TabIndex = 4;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer";
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.Location = new System.Drawing.Point(147, 217);
            this.textBoxPostcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.Size = new System.Drawing.Size(223, 26);
            this.textBoxPostcode.TabIndex = 9;
            this.textBoxPostcode.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "&Postcode:";
            // 
            // textBoxTown
            // 
            this.textBoxTown.Location = new System.Drawing.Point(147, 171);
            this.textBoxTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(223, 26);
            this.textBoxTown.TabIndex = 7;
            this.textBoxTown.Text = "Zagreb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Town/City:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(147, 125);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(223, 26);
            this.textBoxStreet.TabIndex = 5;
            this.textBoxStreet.Text = "Trg Bana Jelačića 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Street address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxShippingPostcode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxShippingTown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxShippingAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxShippingFamilyName);
            this.groupBox1.Controls.Add(this.textBoxShippingName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(408, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(381, 274);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Information";
            // 
            // textBoxShippingPostcode
            // 
            this.textBoxShippingPostcode.Location = new System.Drawing.Point(147, 217);
            this.textBoxShippingPostcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxShippingPostcode.Name = "textBoxShippingPostcode";
            this.textBoxShippingPostcode.Size = new System.Drawing.Size(223, 26);
            this.textBoxShippingPostcode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Postcode:";
            // 
            // textBoxShippingTown
            // 
            this.textBoxShippingTown.Location = new System.Drawing.Point(147, 171);
            this.textBoxShippingTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxShippingTown.Name = "textBoxShippingTown";
            this.textBoxShippingTown.Size = new System.Drawing.Size(223, 26);
            this.textBoxShippingTown.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "&Town/City:";
            // 
            // textBoxShippingAddress
            // 
            this.textBoxShippingAddress.Location = new System.Drawing.Point(147, 125);
            this.textBoxShippingAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxShippingAddress.Name = "textBoxShippingAddress";
            this.textBoxShippingAddress.Size = new System.Drawing.Size(223, 26);
            this.textBoxShippingAddress.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "&Street address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "First &name:";
            // 
            // textBoxShippingFamilyName
            // 
            this.textBoxShippingFamilyName.Location = new System.Drawing.Point(147, 80);
            this.textBoxShippingFamilyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxShippingFamilyName.Name = "textBoxShippingFamilyName";
            this.textBoxShippingFamilyName.Size = new System.Drawing.Size(223, 26);
            this.textBoxShippingFamilyName.TabIndex = 3;
            // 
            // textBoxShippingName
            // 
            this.textBoxShippingName.Location = new System.Drawing.Point(147, 35);
            this.textBoxShippingName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxShippingName.Name = "textBoxShippingName";
            this.textBoxShippingName.Size = new System.Drawing.Size(223, 26);
            this.textBoxShippingName.TabIndex = 1;
            this.textBoxShippingName.Enter += new System.EventHandler(this.textBoxShippingName_Enter);
            this.textBoxShippingName.Leave += new System.EventHandler(this.textBoxShippingName_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "&Family name:";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(555, 334);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 35);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(676, 334);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 388);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Order Details";
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFamilyName;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox textBoxPostcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxShippingPostcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxShippingTown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxShippingAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxShippingFamilyName;
        private System.Windows.Forms.TextBox textBoxShippingName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}

