namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbAgent = new ComboBox();
            txtPaymentAmount = new TextBox();
            label6 = new Label();
            cmbPackageType = new ComboBox();
            btnSaveAd = new Button();
            cmbAdType = new ComboBox();
            txtAdText = new RichTextBox();
            label2 = new Label();
            cmbCustomer = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 55);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Advertising";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 267);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 2;
            label3.Text = "Advertising Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 334);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Agent";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 403);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 4;
            label5.Text = "Payment Amount";
            // 
            // cmbAgent
            // 
            cmbAgent.FormattingEnabled = true;
            cmbAgent.Location = new Point(406, 334);
            cmbAgent.Name = "cmbAgent";
            cmbAgent.Size = new Size(182, 33);
            cmbAgent.TabIndex = 9;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Location = new Point(405, 400);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(183, 31);
            txtPaymentAmount.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 474);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 11;
            label6.Text = "Package Type";
            // 
            // cmbPackageType
            // 
            cmbPackageType.FormattingEnabled = true;
            cmbPackageType.Items.AddRange(new object[] { "One-Time", "Package" });
            cmbPackageType.Location = new Point(405, 471);
            cmbPackageType.Name = "cmbPackageType";
            cmbPackageType.Size = new Size(182, 33);
            cmbPackageType.TabIndex = 12;
            // 
            // btnSaveAd
            // 
            btnSaveAd.Location = new Point(783, 504);
            btnSaveAd.Name = "btnSaveAd";
            btnSaveAd.Size = new Size(259, 66);
            btnSaveAd.TabIndex = 13;
            btnSaveAd.Text = "Save Advertise";
            btnSaveAd.UseVisualStyleBackColor = true;
            btnSaveAd.Click += button1_Click;
            // 
            // cmbAdType
            // 
            cmbAdType.FormattingEnabled = true;
            cmbAdType.Location = new Point(406, 267);
            cmbAdType.Name = "cmbAdType";
            cmbAdType.Size = new Size(182, 33);
            cmbAdType.TabIndex = 14;
            // 
            // txtAdText
            // 
            txtAdText.Location = new Point(406, 36);
            txtAdText.Name = "txtAdText";
            txtAdText.Size = new Size(150, 144);
            txtAdText.TabIndex = 15;
            txtAdText.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 207);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 16;
            label2.Text = "Customer ";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(406, 207);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(182, 33);
            cmbCustomer.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 600);
            Controls.Add(cmbCustomer);
            Controls.Add(label2);
            Controls.Add(txtAdText);
            Controls.Add(cmbAdType);
            Controls.Add(btnSaveAd);
            Controls.Add(cmbPackageType);
            Controls.Add(label6);
            Controls.Add(txtPaymentAmount);
            Controls.Add(cmbAgent);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private ComboBox cmbAgent;
        private TextBox txtPaymentAmount;
        private Label label6;
        private ComboBox cmbPackageType;
        private Button btnSaveAd;
        private ComboBox cmbAdType;
        private RichTextBox txtAdText;
        private Label label2;
        private ComboBox cmbCustomer;
    }
}
