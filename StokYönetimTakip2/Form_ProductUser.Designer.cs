namespace StokYönetimTakip2
{
    partial class Form_ProductUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ProductUser));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.combo_product = new System.Windows.Forms.ComboBox();
            this.btn_ürün_ekle = new System.Windows.Forms.Button();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.combo_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbl_l = new System.Windows.Forms.Label();
            this.rd_encok = new System.Windows.Forms.RadioButton();
            this.btn_ana_forma_gecis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1198, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.combo_product);
            this.groupBox1.Controls.Add(this.btn_ürün_ekle);
            this.groupBox1.Controls.Add(this.combo_category);
            this.groupBox1.Controls.Add(this.combo_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 392);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YENİ ÜRÜN EKLE";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(150, 273);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(286, 28);
            this.txt_quantity.TabIndex = 7;
            // 
            // combo_product
            // 
            this.combo_product.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_product.FormattingEnabled = true;
            this.combo_product.Location = new System.Drawing.Point(150, 209);
            this.combo_product.Name = "combo_product";
            this.combo_product.Size = new System.Drawing.Size(286, 27);
            this.combo_product.TabIndex = 6;
            // 
            // btn_ürün_ekle
            // 
            this.btn_ürün_ekle.BackColor = System.Drawing.Color.MistyRose;
            this.btn_ürün_ekle.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ürün_ekle.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_ürün_ekle.Location = new System.Drawing.Point(94, 322);
            this.btn_ürün_ekle.Name = "btn_ürün_ekle";
            this.btn_ürün_ekle.Size = new System.Drawing.Size(241, 48);
            this.btn_ürün_ekle.TabIndex = 8;
            this.btn_ürün_ekle.Text = "Ürün Ekle";
            this.btn_ürün_ekle.UseVisualStyleBackColor = false;
            this.btn_ürün_ekle.Click += new System.EventHandler(this.btn_ürün_ekle_Click);
            // 
            // combo_category
            // 
            this.combo_category.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(150, 137);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(286, 27);
            this.combo_category.TabIndex = 5;
            // 
            // combo_name
            // 
            this.combo_name.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_name.FormattingEnabled = true;
            this.combo_name.Location = new System.Drawing.Point(150, 69);
            this.combo_name.Name = "combo_name";
            this.combo_name.Size = new System.Drawing.Size(286, 27);
            this.combo_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.MistyRose;
            this.btn_sil.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_sil.Location = new System.Drawing.Point(892, 271);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(153, 61);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.MistyRose;
            this.btn_listele.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listele.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_listele.Location = new System.Drawing.Point(1051, 271);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(150, 61);
            this.btn_listele.TabIndex = 3;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.lbl_l);
            this.groupBox2.Controls.Add(this.rd_encok);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Location = new System.Drawing.Point(892, 455);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 236);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ISTATISTIKLER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 181);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(268, 33);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ISTATISTIK YENILEME";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbl_l
            // 
            this.lbl_l.AutoSize = true;
            this.lbl_l.Location = new System.Drawing.Point(253, 117);
            this.lbl_l.Name = "lbl_l";
            this.lbl_l.Size = new System.Drawing.Size(0, 29);
            this.lbl_l.TabIndex = 1;
            // 
            // rd_encok
            // 
            this.rd_encok.AutoSize = true;
            this.rd_encok.Location = new System.Drawing.Point(6, 62);
            this.rd_encok.Name = "rd_encok";
            this.rd_encok.Size = new System.Drawing.Size(290, 33);
            this.rd_encok.TabIndex = 0;
            this.rd_encok.TabStop = true;
            this.rd_encok.Text = "EN COK ÜRÜN ALAN KISI";
            this.rd_encok.UseVisualStyleBackColor = true;
            this.rd_encok.CheckedChanged += new System.EventHandler(this.rd_encok_CheckedChanged);
            // 
            // btn_ana_forma_gecis
            // 
            this.btn_ana_forma_gecis.BackColor = System.Drawing.Color.MistyRose;
            this.btn_ana_forma_gecis.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ana_forma_gecis.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_ana_forma_gecis.Location = new System.Drawing.Point(892, 369);
            this.btn_ana_forma_gecis.Name = "btn_ana_forma_gecis";
            this.btn_ana_forma_gecis.Size = new System.Drawing.Size(309, 61);
            this.btn_ana_forma_gecis.TabIndex = 5;
            this.btn_ana_forma_gecis.Text = "ANA FORMA GECIS";
            this.btn_ana_forma_gecis.UseVisualStyleBackColor = false;
            this.btn_ana_forma_gecis.Click += new System.EventHandler(this.btn_ana_forma_gecis_Click);
            // 
            // Form_ProductUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 690);
            this.Controls.Add(this.btn_ana_forma_gecis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ProductUser";
            this.Text = "Form_ProductUser";
            this.Load += new System.EventHandler(this.Form_ProductUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.ComboBox combo_product;
        private System.Windows.Forms.Button btn_ürün_ekle;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.ComboBox combo_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_encok;
        private System.Windows.Forms.Label lbl_l;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_ana_forma_gecis;
        private System.Windows.Forms.Label label5;
    }
}