namespace BlogSitesi
{
    partial class Form2
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
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txt2Sifre = new TextBox();
            txt2KullanıcıAdı = new TextBox();
            txtSifreTekrarı = new TextBox();
            btnKayıtOl = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 58);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 0;
            label10.Text = "Kullanıcı Adı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(99, 120);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 1;
            label11.Text = "Şifre:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(99, 193);
            label12.Name = "label12";
            label12.Size = new Size(90, 20);
            label12.TabIndex = 2;
            label12.Text = "Şifre Tekrarı:";
            // 
            // txt2Sifre
            // 
            txt2Sifre.Location = new Point(200, 117);
            txt2Sifre.Name = "txt2Sifre";
            txt2Sifre.Size = new Size(190, 27);
            txt2Sifre.TabIndex = 3;
            // 
            // txt2KullanıcıAdı
            // 
            txt2KullanıcıAdı.Location = new Point(200, 55);
            txt2KullanıcıAdı.Name = "txt2KullanıcıAdı";
            txt2KullanıcıAdı.Size = new Size(190, 27);
            txt2KullanıcıAdı.TabIndex = 4;
            // 
            // txtSifreTekrarı
            // 
            txtSifreTekrarı.Location = new Point(200, 186);
            txtSifreTekrarı.Name = "txtSifreTekrarı";
            txtSifreTekrarı.Size = new Size(190, 27);
            txtSifreTekrarı.TabIndex = 5;
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.Location = new Point(126, 290);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(122, 29);
            btnKayıtOl.TabIndex = 6;
            btnKayıtOl.Text = "Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = true;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 251);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnKayıtOl);
            Controls.Add(txtSifreTekrarı);
            Controls.Add(txt2KullanıcıAdı);
            Controls.Add(txt2Sifre);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txt2Sifre;
        private TextBox txt2KullanıcıAdı;
        private TextBox txtSifreTekrarı;
        private Button btnKayıtOl;
        private Label label1;
    }
}