namespace BlogSitesi
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
            btnGirisYap = new Button();
            label1 = new Label();
            txtKullanıcıAdı = new TextBox();
            txtSifre = new TextBox();
            label2 = new Label();
            linkKayıtOl = new LinkLabel();
            lblErrorMessage = new Label();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(153, 252);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(159, 29);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 82);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.Location = new Point(125, 117);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(187, 27);
            txtKullanıcıAdı.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(125, 195);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(187, 27);
            txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 161);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // linkKayıtOl
            // 
            linkKayıtOl.AutoSize = true;
            linkKayıtOl.Location = new Point(117, 308);
            linkKayıtOl.Name = "linkKayıtOl";
            linkKayıtOl.Size = new Size(195, 20);
            linkKayıtOl.TabIndex = 5;
            linkKayıtOl.TabStop = true;
            linkKayıtOl.Text = "Kayıtlı Değilseniz Kayıt Olun";
            linkKayıtOl.LinkClicked += linkKayıtOl_LinkClicked;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Location = new Point(117, 229);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 20);
            lblErrorMessage.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrorMessage);
            Controls.Add(linkKayıtOl);
            Controls.Add(label2);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanıcıAdı);
            Controls.Add(label1);
            Controls.Add(btnGirisYap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private Label label1;
        private TextBox txtKullanıcıAdı;
        private TextBox txtSifre;
        private Label label2;
        private LinkLabel linkKayıtOl;
        private Label lblErrorMessage;
    }
}
