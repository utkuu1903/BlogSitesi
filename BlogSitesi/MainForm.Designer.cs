namespace BlogSitesi
{
    partial class MainForm
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
            txtBaslik = new TextBox();
            label1 = new Label();
            pbPostPicture = new PictureBox();
            txtIcerik = new RichTextBox();
            btnEkle = new Button();
            flpPanel = new FlowLayoutPanel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPostPicture).BeginInit();
            SuspendLayout();
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(57, 40);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(125, 27);
            txtBaslik.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 43);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Başlık:";
            // 
            // pbPostPicture
            // 
            pbPostPicture.BackColor = SystemColors.GradientActiveCaption;
            pbPostPicture.Location = new Point(58, 97);
            pbPostPicture.Name = "pbPostPicture";
            pbPostPicture.Size = new Size(124, 145);
            pbPostPicture.TabIndex = 2;
            pbPostPicture.TabStop = false;
            pbPostPicture.Click += pbPostPicture_Click;
            // 
            // txtIcerik
            // 
            txtIcerik.Location = new Point(58, 262);
            txtIcerik.Name = "txtIcerik";
            txtIcerik.Size = new Size(125, 120);
            txtIcerik.TabIndex = 3;
            txtIcerik.Text = "";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(49, 403);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(134, 35);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // flpPanel
            // 
            flpPanel.Location = new Point(242, 26);
            flpPanel.Name = "flpPanel";
            flpPanel.Size = new Size(505, 403);
            flpPanel.TabIndex = 5;
            flpPanel.Paint += flpPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 262);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "İçerik:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(flpPanel);
            Controls.Add(btnEkle);
            Controls.Add(txtIcerik);
            Controls.Add(pbPostPicture);
            Controls.Add(label1);
            Controls.Add(txtBaslik);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbPostPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBaslik;
        private Label label1;
        private PictureBox pbPostPicture;
        private RichTextBox txtIcerik;
        private Button btnEkle;
        private FlowLayoutPanel flpPanel;
        private Label label2;
    }
}