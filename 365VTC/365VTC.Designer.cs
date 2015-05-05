namespace MyUtility
{
    partial class OnlinePaymentSoft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlinePaymentSoft));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhonePayment = new System.Windows.Forms.TabPage();
            this.containerPane = new System.Windows.Forms.Panel();
            this.btnInterPhone = new System.Windows.Forms.Button();
            this.btnFixedPhone = new System.Windows.Forms.Button();
            this.btnCellPhone = new System.Windows.Forms.Button();
            this.tabGameOnline = new System.Windows.Forms.TabPage();
            this.tabTVPayment = new System.Windows.Forms.TabPage();
            this.tabElectricPayment = new System.Windows.Forms.TabPage();
            this.tabInternetPayment = new System.Windows.Forms.TabPage();
            this.tabOtherService = new System.Windows.Forms.TabPage();
            this.tabVisaSmartCash = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPhonePayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 95);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 24);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(799, 451);
            this.webBrowser1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhonePayment);
            this.tabControl1.Controls.Add(this.tabGameOnline);
            this.tabControl1.Controls.Add(this.tabTVPayment);
            this.tabControl1.Controls.Add(this.tabElectricPayment);
            this.tabControl1.Controls.Add(this.tabInternetPayment);
            this.tabControl1.Controls.Add(this.tabOtherService);
            this.tabControl1.Controls.Add(this.tabVisaSmartCash);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 555);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPhonePayment
            // 
            this.tabPhonePayment.Controls.Add(this.containerPane);
            this.tabPhonePayment.Controls.Add(this.btnInterPhone);
            this.tabPhonePayment.Controls.Add(this.btnFixedPhone);
            this.tabPhonePayment.Controls.Add(this.btnCellPhone);
            this.tabPhonePayment.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPhonePayment.Location = new System.Drawing.Point(4, 25);
            this.tabPhonePayment.Name = "tabPhonePayment";
            this.tabPhonePayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhonePayment.Size = new System.Drawing.Size(795, 526);
            this.tabPhonePayment.TabIndex = 0;
            this.tabPhonePayment.Text = "Cước Điện Thoại";
            this.tabPhonePayment.UseVisualStyleBackColor = true;
            // 
            // containerPane
            // 
            this.containerPane.Location = new System.Drawing.Point(76, 72);
            this.containerPane.Name = "containerPane";
            this.containerPane.Size = new System.Drawing.Size(640, 430);
            this.containerPane.TabIndex = 0;
            // 
            // btnInterPhone
            // 
            this.btnInterPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterPhone.Location = new System.Drawing.Point(505, 21);
            this.btnInterPhone.Name = "btnInterPhone";
            this.btnInterPhone.Size = new System.Drawing.Size(154, 26);
            this.btnInterPhone.TabIndex = 1;
            this.btnInterPhone.Text = "Điện Thoại Quốc Tế";
            this.btnInterPhone.UseVisualStyleBackColor = true;
            this.btnInterPhone.Click += new System.EventHandler(this.btnInterPhone_Click);
            // 
            // btnFixedPhone
            // 
            this.btnFixedPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixedPhone.Location = new System.Drawing.Point(317, 21);
            this.btnFixedPhone.Name = "btnFixedPhone";
            this.btnFixedPhone.Size = new System.Drawing.Size(154, 26);
            this.btnFixedPhone.TabIndex = 1;
            this.btnFixedPhone.Text = "Điện Thoại Cố Định";
            this.btnFixedPhone.UseVisualStyleBackColor = true;
            this.btnFixedPhone.Click += new System.EventHandler(this.btnFixedPhone_Click);
            // 
            // btnCellPhone
            // 
            this.btnCellPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCellPhone.Location = new System.Drawing.Point(129, 21);
            this.btnCellPhone.Name = "btnCellPhone";
            this.btnCellPhone.Size = new System.Drawing.Size(154, 26);
            this.btnCellPhone.TabIndex = 1;
            this.btnCellPhone.Text = "Điện Thoại Di Động";
            this.btnCellPhone.UseVisualStyleBackColor = true;
            this.btnCellPhone.Click += new System.EventHandler(this.btnCellPhone_Click);
            // 
            // tabGameOnline
            // 
            this.tabGameOnline.Location = new System.Drawing.Point(4, 25);
            this.tabGameOnline.Name = "tabGameOnline";
            this.tabGameOnline.Padding = new System.Windows.Forms.Padding(3);
            this.tabGameOnline.Size = new System.Drawing.Size(795, 526);
            this.tabGameOnline.TabIndex = 1;
            this.tabGameOnline.Text = "Game Online";
            this.tabGameOnline.UseVisualStyleBackColor = true;
            // 
            // tabTVPayment
            // 
            this.tabTVPayment.Location = new System.Drawing.Point(4, 25);
            this.tabTVPayment.Name = "tabTVPayment";
            this.tabTVPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabTVPayment.Size = new System.Drawing.Size(795, 526);
            this.tabTVPayment.TabIndex = 2;
            this.tabTVPayment.Text = "Cước Truyền Hình";
            this.tabTVPayment.UseVisualStyleBackColor = true;
            // 
            // tabElectricPayment
            // 
            this.tabElectricPayment.Location = new System.Drawing.Point(4, 25);
            this.tabElectricPayment.Name = "tabElectricPayment";
            this.tabElectricPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabElectricPayment.Size = new System.Drawing.Size(795, 526);
            this.tabElectricPayment.TabIndex = 3;
            this.tabElectricPayment.Text = "Tiền Điện Nước";
            this.tabElectricPayment.UseVisualStyleBackColor = true;
            // 
            // tabInternetPayment
            // 
            this.tabInternetPayment.Location = new System.Drawing.Point(4, 25);
            this.tabInternetPayment.Name = "tabInternetPayment";
            this.tabInternetPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternetPayment.Size = new System.Drawing.Size(795, 526);
            this.tabInternetPayment.TabIndex = 4;
            this.tabInternetPayment.Text = "Cước Internet";
            this.tabInternetPayment.UseVisualStyleBackColor = true;
            // 
            // tabOtherService
            // 
            this.tabOtherService.Location = new System.Drawing.Point(4, 25);
            this.tabOtherService.Name = "tabOtherService";
            this.tabOtherService.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtherService.Size = new System.Drawing.Size(795, 526);
            this.tabOtherService.TabIndex = 5;
            this.tabOtherService.Text = "Dịch Vụ Khác";
            this.tabOtherService.UseVisualStyleBackColor = true;
            // 
            // tabVisaSmartCash
            // 
            this.tabVisaSmartCash.Location = new System.Drawing.Point(4, 25);
            this.tabVisaSmartCash.Name = "tabVisaSmartCash";
            this.tabVisaSmartCash.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisaSmartCash.Size = new System.Drawing.Size(795, 526);
            this.tabVisaSmartCash.TabIndex = 6;
            this.tabVisaSmartCash.Text = "VISA SMARTCASH";
            this.tabVisaSmartCash.UseVisualStyleBackColor = true;
            // 
            // OnlinePaymentSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OnlinePaymentSoft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán Cước 365";
            this.Load += new System.EventHandler(this.OnlinePaymentSoft_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPhonePayment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGameOnline;
        private System.Windows.Forms.TabPage tabPhonePayment;
        private System.Windows.Forms.TabPage tabTVPayment;
        private System.Windows.Forms.TabPage tabElectricPayment;
        private System.Windows.Forms.TabPage tabInternetPayment;
        private System.Windows.Forms.Panel containerPane;
        private System.Windows.Forms.TabPage tabOtherService;
        private System.Windows.Forms.TabPage tabVisaSmartCash;
        private System.Windows.Forms.Button btnInterPhone;
        private System.Windows.Forms.Button btnFixedPhone;
        private System.Windows.Forms.Button btnCellPhone;


    }
}