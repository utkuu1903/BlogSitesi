using BlogSitesi.context;
using BlogSitesi.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogSitesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        BlogDbContext _db = new BlogDbContext();
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            string yeniKullanıcı = txt2KullanıcıAdı.Text;
            string yeniSifre = txt2Sifre.Text;
            string SifreTekrarı = txtSifreTekrarı.Text;

            if (yeniKullanıcı == null || yeniKullanıcı=="")
            {
                label1.Text = "Lütfen Burayı Doldurunuz";
                return;

            }

            if (yeniSifre != SifreTekrarı) 
            {
                label1.Text = "Şifreler Eşleşmiyor";
                return;
            }
            if (yeniKullanıcı != null)
            {
                label1.Text = "Bu Kullanıcı Adı Alınmış";
            }
            User user = new User()
            {
                UserName = txt2KullanıcıAdı.Text,
                Password = txt2Sifre.Text

            };

            _db.Users.Add(user);
            _db.SaveChanges();
            label1.Text = "Kayıt Başarılı";

            


            
        }
    }
}
