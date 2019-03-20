namespace Aracgaleri
{
    partial class KullaniciEkle
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arabaKullaniciDataSet1 = new Aracgaleri.ArabaKullaniciDataSet1();
            this.kullaniciAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciAdminTableAdapter = new Aracgaleri.ArabaKullaniciDataSet1TableAdapters.KullaniciAdminTableAdapter();
            this.kullaniciİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaKullaniciDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(148, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(31, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciİdDataGridViewTextBoxColumn,
            this.kadDataGridViewTextBoxColumn,
            this.girisTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullaniciAdminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(364, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 160);
            this.dataGridView1.TabIndex = 6;
            // 
            // arabaKullaniciDataSet1
            // 
            this.arabaKullaniciDataSet1.DataSetName = "ArabaKullaniciDataSet1";
            this.arabaKullaniciDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciAdminBindingSource
            // 
            this.kullaniciAdminBindingSource.DataMember = "KullaniciAdmin";
            this.kullaniciAdminBindingSource.DataSource = this.arabaKullaniciDataSet1;
            // 
            // kullaniciAdminTableAdapter
            // 
            this.kullaniciAdminTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciİdDataGridViewTextBoxColumn
            // 
            this.kullaniciİdDataGridViewTextBoxColumn.DataPropertyName = "Kullaniciİd";
            this.kullaniciİdDataGridViewTextBoxColumn.HeaderText = "Kullaniciİd";
            this.kullaniciİdDataGridViewTextBoxColumn.Name = "kullaniciİdDataGridViewTextBoxColumn";
            this.kullaniciİdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kadDataGridViewTextBoxColumn
            // 
            this.kadDataGridViewTextBoxColumn.DataPropertyName = "Kad";
            this.kadDataGridViewTextBoxColumn.HeaderText = "Kad";
            this.kadDataGridViewTextBoxColumn.Name = "kadDataGridViewTextBoxColumn";
            this.kadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // girisTarihDataGridViewTextBoxColumn
            // 
            this.girisTarihDataGridViewTextBoxColumn.DataPropertyName = "GirisTarih";
            this.girisTarihDataGridViewTextBoxColumn.HeaderText = "GirisTarih";
            this.girisTarihDataGridViewTextBoxColumn.Name = "girisTarihDataGridViewTextBoxColumn";
            this.girisTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(21, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Seçilen kullanıcı silmek için tıklayınız";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aracgaleri.Properties.Resources.resim;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "KullaniciEkle";
            this.Text = "KullaniciEkle";
            this.Load += new System.EventHandler(this.KullaniciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaKullaniciDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ArabaKullaniciDataSet1 arabaKullaniciDataSet1;
        private System.Windows.Forms.BindingSource kullaniciAdminBindingSource;
        private ArabaKullaniciDataSet1TableAdapters.KullaniciAdminTableAdapter kullaniciAdminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}