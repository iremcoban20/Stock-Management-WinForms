using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYönetimTakip2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UserDbContext db = new UserDbContext();

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var users = db.Users.ToList();
                dataGridView1.DataSource = users;

                dataGridView1.Columns["user_id"].HeaderText = "Kullanıcı Id";
                dataGridView1.Columns["user_name"].HeaderText = "Kullanıcı Adı";
                dataGridView1.Columns["user_phone_number"].HeaderText = "Kullanıcı Telefon Numarası";

                dataGridView1.Columns["user_id"].Visible = false;

                dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_kayıt_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Users newUsers = new Users()
                {
                    user_name=txt_name.Text,
                    user_phone_number=txt_phone.Text,
                };
                db.Users.Add(newUsers);
                db.SaveChanges();

                MessageBox.Show("Yeni Kullanıcı Eklendi!");
                btn_listele.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells["user_name"].Value.ToString();
                txt_phone.Text = dataGridView1.Rows[e.RowIndex].Cells["user_phone_number"].Value.ToString();

            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.CurrentRow != null)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["user_id"].Value);
                    Users users = db.Users.Find(selectedId);
                    if(users != null) 
                    {
                        users.user_name = txt_name.Text;
                        users.user_phone_number = txt_phone.Text;

                        db.SaveChanges();

                        MessageBox.Show("Müşteri güncellendi!");

                        btn_listele.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");

            }
        }

        private void btn_kayıt_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show(
                    "Silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (DialogResult.Yes == sonuc)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["user_id"].Value);
                        Users users = db.Users.Find(selectedId);

                        if (users != null) 
                        {
                            db.Users.Remove(users);
                            db.SaveChanges();

                            MessageBox.Show("Müşteri Silindi!");
                            btn_listele.PerformClick();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");

            }
        }

        private void btn_forma_geçiş_Click(object sender, EventArgs e)
        {
            Form_ProductUser form2_pu = new Form_ProductUser();
            this.Hide();
            form2_pu.ShowDialog();
            this.Close();
        }
    }
}
