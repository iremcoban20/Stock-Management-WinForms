using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StokYönetimTakip2
{
    public partial class Form_ProductUser : Form
    {
        public Form_ProductUser()
        {
            InitializeComponent();
        }
        UserDbContext db = new UserDbContext();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var list = db.ProductUsers
                    .Include(pu => pu.Category)
                     .Select(pu => new
                     {
                         pu.Product_User_id,
                         KullanıcıAdı = pu.Users.user_name,

                         Kategori = pu.Product.Category.Category_name,

                         Ürün = pu.Product.product_name,

                         Adet = pu.Quantity_taken

                     })
                     .ToList();
                dataGridView1.DataSource = list;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["Product_User_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }

        }

        private void Form_ProductUser_Load(object sender, EventArgs e)
        {
            try
            {
                combo_name.DataSource = db.Users
                    .OrderBy(u => u.user_name)
                    .Select(u => new
                    {
                        u.user_id,
                        Name = u.user_name
                    })
                    .ToList();
                combo_name.DisplayMember = "Name";
                combo_name.ValueMember = "user_id";

                combo_category.DataSource = db.Categories
                    .OrderBy(p => p.Category_id)
                    .Select(p => new
                    {
                        p.Category_id,
                        Category = p.Category_name
                    })
                    .ToList();
                combo_category.DisplayMember = "Category";
                combo_category.ValueMember = "Category_id";

                combo_product.DataSource = db.Products
                    .Include(p => p.product_id)
                    .OrderBy(p => p.product_name)
                    .Select(p => new
                    {
                        p.product_id,
                        ProductInfo = (p.Category.Category_name) + " - " + p.product_name
                    })
                    .ToList();
                combo_product.DisplayMember = "ProductInfo";
                combo_product.ValueMember = "product_id";
                

               
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");

            }
        }

        private void btn_ürün_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedUserId = (int)combo_name.SelectedValue;
                int selectedCategoryId = (int)combo_category.SelectedValue;
                int selectedProductId = (int)combo_product.SelectedValue;
                int selectedQuantity = (int)combo_product.SelectedValue;                                

                var newRecord = new ProductUser
                {
                    Quantity_taken = Convert.ToInt32(txt_quantity.Text),
                    user_id = selectedUserId,
                    Category_id = selectedCategoryId,
                    product_id = selectedProductId

                };
                db.ProductUsers.Add(newRecord);
                db.SaveChanges();

                MessageBox.Show("Kayıt başarıyla eklendi.");

                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");

            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show(
                           "Silmek istediğinize emin misiniz?",
                           "Silme Onayı",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Product_User_id"].Value);
                        var recordToDelete = db.ProductUsers.Find(selectedId);

                        if (recordToDelete != null)
                        {
                            db.ProductUsers.Remove(recordToDelete);
                            db.SaveChanges();

                            MessageBox.Show("Kayıt başarıyla silindi.");

                            btn_listele.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt bulunamadı.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }

        }

        private void rd_encok_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_encok.Checked)
                {
                    var result = db.ProductUsers
                        .GroupBy(pu => pu.Users.user_name)
                        .Select(g => new
                        {
                            Name = g.Key,
                            TotalCount = g.Sum(x => x.Quantity_taken)

                        })
                        .OrderByDescending(x => x.TotalCount)
                        .FirstOrDefault();

                    if (result != null)
                    {
                        label5.Text = $"{result.Name} {result.TotalCount} ürün almıs";
                    }
                    else
                    {
                        label5.Text = "Kayıt Bulunamadı";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( $"Hata = {ex.Message}");
            }
        }

        private void btn_ana_forma_gecis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                combo_name.Text = selectedRow.Cells[1].Value?.ToString();
                combo_category.Text = selectedRow.Cells[2].Value?.ToString();
                combo_product.Text = selectedRow.Cells[3].Value?.ToString();
                txt_quantity.Text = selectedRow.Cells[4].Value?.ToString();
            }



        }
    }
    
}