namespace StokYönetimTakip2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btn_kayıt_ekle = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_forma_geçiş = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_kayıt_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1199, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.btn_güncelle);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.btn_kayıt_ekle);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(27, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YENI KAYIT EKLE";
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackColor = System.Drawing.Color.MistyRose;
            this.btn_güncelle.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_güncelle.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_güncelle.Location = new System.Drawing.Point(347, 211);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(255, 41);
            this.btn_güncelle.TabIndex = 3;
            this.btn_güncelle.Text = "Kayıt Güncele";
            this.btn_güncelle.UseVisualStyleBackColor = false;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(272, 132);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(286, 28);
            this.txt_phone.TabIndex = 3;
            // 
            // btn_kayıt_ekle
            // 
            this.btn_kayıt_ekle.BackColor = System.Drawing.Color.MistyRose;
            this.btn_kayıt_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kayıt_ekle.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kayıt_ekle.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_kayıt_ekle.Location = new System.Drawing.Point(23, 211);
            this.btn_kayıt_ekle.Name = "btn_kayıt_ekle";
            this.btn_kayıt_ekle.Size = new System.Drawing.Size(268, 43);
            this.btn_kayıt_ekle.TabIndex = 2;
            this.btn_kayıt_ekle.Text = "Kayıt Ekle";
            this.btn_kayıt_ekle.UseVisualStyleBackColor = false;
            this.btn_kayıt_ekle.Click += new System.EventHandler(this.btn_kayıt_ekle_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(272, 54);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(286, 28);
            this.txt_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btn_forma_geçiş);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Location = new System.Drawing.Point(797, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 234);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FORMLARA GEÇIS";
            // 
            // btn_forma_geçiş
            // 
            this.btn_forma_geçiş.BackColor = System.Drawing.Color.MistyRose;
            this.btn_forma_geçiş.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forma_geçiş.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_forma_geçiş.Location = new System.Drawing.Point(50, 57);
            this.btn_forma_geçiş.Name = "btn_forma_geçiş";
            this.btn_forma_geçiş.Size = new System.Drawing.Size(253, 162);
            this.btn_forma_geçiş.TabIndex = 0;
            this.btn_forma_geçiş.Text = "FORM PRODUCTUSER\'A GEÇIS";
            this.btn_forma_geçiş.UseVisualStyleBackColor = false;
            this.btn_forma_geçiş.Click += new System.EventHandler(this.btn_forma_geçiş_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.MistyRose;
            this.btn_listele.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listele.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_listele.Location = new System.Drawing.Point(784, 291);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(190, 60);
            this.btn_listele.TabIndex = 3;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_kayıt_sil
            // 
            this.btn_kayıt_sil.BackColor = System.Drawing.Color.MistyRose;
            this.btn_kayıt_sil.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kayıt_sil.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_kayıt_sil.Location = new System.Drawing.Point(993, 291);
            this.btn_kayıt_sil.Name = "btn_kayıt_sil";
            this.btn_kayıt_sil.Size = new System.Drawing.Size(190, 60);
            this.btn_kayıt_sil.TabIndex = 4;
            this.btn_kayıt_sil.Text = "Kayıt Sil";
            this.btn_kayıt_sil.UseVisualStyleBackColor = false;
            this.btn_kayıt_sil.Click += new System.EventHandler(this.btn_kayıt_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1209, 619);
            this.Controls.Add(this.btn_kayıt_sil);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_kayıt_ekle;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_forma_geçiş;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_kayıt_sil;
    }
}

