using BlogSitesi.context;
using BlogSitesi.Entities;

namespace BlogSitesi
{
    public partial class Form1 : Form
    {
        private readonly BlogDbContext _context;
        


        public Form1(BlogDbContext context)
        {
            InitializeComponent();
            _context = context;
            
        }

        private void linkKayýtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();

        }

        private void txtKullanýcýAdý_TextChanged(object sender, EventArgs e)
        {




        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = txtKullanýcýAdý.Text;
            string sifre = txtSifre.Text;
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                
            }

            var user = _context.Users.FirstOrDefault (x=>x.UserName == kullaniciAdi && x.Password == sifre);
            if (user != null) 
            {
                MainForm mainForm = new MainForm(_context,user);
                    mainForm.Show();
                   lblErrorMessage.Text = "Giriþ Baþarýlý";

            }


            //if (kullaniciAdi == txtKullanýcýAdý.Text && sifre == txtSifre.Text) 

            //{
            //MainForm mainForm = new MainForm();
            //    mainForm.Show();
            //    lblErrorMessage.Text = "Giriþ Baþarýlý";


        }


        
    }
}
