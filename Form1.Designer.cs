namespace PBO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIDPer = new System.Windows.Forms.Label();
            this.txtIDPer = new System.Windows.Forms.TextBox();
            this.txtNamaPer = new System.Windows.Forms.TextBox();
            this.lblNamaPer = new System.Windows.Forms.Label();
            this.txtSektorPer = new System.Windows.Forms.TextBox();
            this.lblSektorPer = new System.Windows.Forms.Label();
            this.txtJenisPer = new System.Windows.Forms.TextBox();
            this.lblJenisPer = new System.Windows.Forms.Label();
            this.txtAlamatPer = new System.Windows.Forms.TextBox();
            this.lblAlamatPer = new System.Windows.Forms.Label();
            this.txtLimbahHasil = new System.Windows.Forms.TextBox();
            this.lblLimbahHasil = new System.Windows.Forms.Label();
            this.txtLimbahKelola = new System.Windows.Forms.TextBox();
            this.lblLimbahKelola = new System.Windows.Forms.Label();
            this.txtLimbahSimpan = new System.Windows.Forms.TextBox();
            this.lblLimbahSimpan = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvListPer = new System.Windows.Forms.DataGridView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblCari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblIDPer
            // 
            this.lblIDPer.AutoSize = true;
            this.lblIDPer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPer.Location = new System.Drawing.Point(268, 63);
            this.lblIDPer.Name = "lblIDPer";
            this.lblIDPer.Size = new System.Drawing.Size(169, 25);
            this.lblIDPer.TabIndex = 1;
            this.lblIDPer.Text = "ID Perusahaan:";
            // 
            // txtIDPer
            // 
            this.txtIDPer.Location = new System.Drawing.Point(573, 65);
            this.txtIDPer.Name = "txtIDPer";
            this.txtIDPer.ReadOnly = true;
            this.txtIDPer.Size = new System.Drawing.Size(295, 26);
            this.txtIDPer.TabIndex = 2;
            // 
            // txtNamaPer
            // 
            this.txtNamaPer.Location = new System.Drawing.Point(573, 107);
            this.txtNamaPer.Name = "txtNamaPer";
            this.txtNamaPer.Size = new System.Drawing.Size(295, 26);
            this.txtNamaPer.TabIndex = 4;
            // 
            // lblNamaPer
            // 
            this.lblNamaPer.AutoSize = true;
            this.lblNamaPer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPer.Location = new System.Drawing.Point(268, 105);
            this.lblNamaPer.Name = "lblNamaPer";
            this.lblNamaPer.Size = new System.Drawing.Size(204, 25);
            this.lblNamaPer.TabIndex = 3;
            this.lblNamaPer.Text = "Nama Perusahaan:";
            // 
            // txtSektorPer
            // 
            this.txtSektorPer.Location = new System.Drawing.Point(573, 151);
            this.txtSektorPer.Name = "txtSektorPer";
            this.txtSektorPer.Size = new System.Drawing.Size(295, 26);
            this.txtSektorPer.TabIndex = 6;
            // 
            // lblSektorPer
            // 
            this.lblSektorPer.AutoSize = true;
            this.lblSektorPer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSektorPer.Location = new System.Drawing.Point(268, 149);
            this.lblSektorPer.Name = "lblSektorPer";
            this.lblSektorPer.Size = new System.Drawing.Size(213, 25);
            this.lblSektorPer.TabIndex = 5;
            this.lblSektorPer.Text = "Sektor Perusahaan:";
            // 
            // txtJenisPer
            // 
            this.txtJenisPer.Location = new System.Drawing.Point(573, 201);
            this.txtJenisPer.Name = "txtJenisPer";
            this.txtJenisPer.Size = new System.Drawing.Size(295, 26);
            this.txtJenisPer.TabIndex = 8;
            // 
            // lblJenisPer
            // 
            this.lblJenisPer.AutoSize = true;
            this.lblJenisPer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisPer.Location = new System.Drawing.Point(268, 199);
            this.lblJenisPer.Name = "lblJenisPer";
            this.lblJenisPer.Size = new System.Drawing.Size(196, 25);
            this.lblJenisPer.TabIndex = 7;
            this.lblJenisPer.Text = "Jenis Perusahaan:";
            // 
            // txtAlamatPer
            // 
            this.txtAlamatPer.Location = new System.Drawing.Point(573, 243);
            this.txtAlamatPer.Multiline = true;
            this.txtAlamatPer.Name = "txtAlamatPer";
            this.txtAlamatPer.Size = new System.Drawing.Size(295, 76);
            this.txtAlamatPer.TabIndex = 10;
            // 
            // lblAlamatPer
            // 
            this.lblAlamatPer.AutoSize = true;
            this.lblAlamatPer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlamatPer.Location = new System.Drawing.Point(268, 241);
            this.lblAlamatPer.Name = "lblAlamatPer";
            this.lblAlamatPer.Size = new System.Drawing.Size(217, 25);
            this.lblAlamatPer.TabIndex = 9;
            this.lblAlamatPer.Text = "Alamat Perusahaan:";
            // 
            // txtLimbahHasil
            // 
            this.txtLimbahHasil.Location = new System.Drawing.Point(573, 342);
            this.txtLimbahHasil.Name = "txtLimbahHasil";
            this.txtLimbahHasil.Size = new System.Drawing.Size(295, 26);
            this.txtLimbahHasil.TabIndex = 12;
            // 
            // lblLimbahHasil
            // 
            this.lblLimbahHasil.AutoSize = true;
            this.lblLimbahHasil.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimbahHasil.Location = new System.Drawing.Point(268, 340);
            this.lblLimbahHasil.Name = "lblLimbahHasil";
            this.lblLimbahHasil.Size = new System.Drawing.Size(285, 25);
            this.lblLimbahHasil.TabIndex = 11;
            this.lblLimbahHasil.Text = "Jumlah Limbah Dihasilkan:";
            // 
            // txtLimbahKelola
            // 
            this.txtLimbahKelola.Location = new System.Drawing.Point(573, 390);
            this.txtLimbahKelola.Name = "txtLimbahKelola";
            this.txtLimbahKelola.Size = new System.Drawing.Size(295, 26);
            this.txtLimbahKelola.TabIndex = 14;
            // 
            // lblLimbahKelola
            // 
            this.lblLimbahKelola.AutoSize = true;
            this.lblLimbahKelola.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimbahKelola.Location = new System.Drawing.Point(268, 388);
            this.lblLimbahKelola.Name = "lblLimbahKelola";
            this.lblLimbahKelola.Size = new System.Drawing.Size(261, 25);
            this.lblLimbahKelola.TabIndex = 13;
            this.lblLimbahKelola.Text = "Jumlah Limbah Dikelola:";
            // 
            // txtLimbahSimpan
            // 
            this.txtLimbahSimpan.Location = new System.Drawing.Point(573, 433);
            this.txtLimbahSimpan.Name = "txtLimbahSimpan";
            this.txtLimbahSimpan.ReadOnly = true;
            this.txtLimbahSimpan.Size = new System.Drawing.Size(295, 26);
            this.txtLimbahSimpan.TabIndex = 16;
            // 
            // lblLimbahSimpan
            // 
            this.lblLimbahSimpan.AutoSize = true;
            this.lblLimbahSimpan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimbahSimpan.Location = new System.Drawing.Point(268, 432);
            this.lblLimbahSimpan.Name = "lblLimbahSimpan";
            this.lblLimbahSimpan.Size = new System.Drawing.Size(273, 25);
            this.lblLimbahSimpan.TabIndex = 15;
            this.lblLimbahSimpan.Text = "Jumlah Limbah Disimpan:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(470, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 40);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(643, 519);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 40);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(815, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(988, 519);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 40);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvListPer
            // 
            this.dgvListPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPer.Location = new System.Drawing.Point(902, 105);
            this.dgvListPer.Name = "dgvListPer";
            this.dgvListPer.RowHeadersWidth = 62;
            this.dgvListPer.RowTemplate.Height = 28;
            this.dgvListPer.Size = new System.Drawing.Size(543, 355);
            this.dgvListPer.TabIndex = 21;
            this.dgvListPer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListPer_RowHeaderMouseClick);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(965, 67);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(480, 26);
            this.txtCari.TabIndex = 23;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCari.Location = new System.Drawing.Point(897, 65);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(62, 25);
            this.lblCari.TabIndex = 22;
            this.lblCari.Text = "Cari:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1487, 651);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.dgvListPer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLimbahSimpan);
            this.Controls.Add(this.lblLimbahSimpan);
            this.Controls.Add(this.txtLimbahKelola);
            this.Controls.Add(this.lblLimbahKelola);
            this.Controls.Add(this.txtLimbahHasil);
            this.Controls.Add(this.lblLimbahHasil);
            this.Controls.Add(this.txtAlamatPer);
            this.Controls.Add(this.lblAlamatPer);
            this.Controls.Add(this.txtJenisPer);
            this.Controls.Add(this.lblJenisPer);
            this.Controls.Add(this.txtSektorPer);
            this.Controls.Add(this.lblSektorPer);
            this.Controls.Add(this.txtNamaPer);
            this.Controls.Add(this.lblNamaPer);
            this.Controls.Add(this.txtIDPer);
            this.Controls.Add(this.lblIDPer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIDPer;
        private System.Windows.Forms.TextBox txtIDPer;
        private System.Windows.Forms.TextBox txtNamaPer;
        private System.Windows.Forms.Label lblNamaPer;
        private System.Windows.Forms.TextBox txtSektorPer;
        private System.Windows.Forms.Label lblSektorPer;
        private System.Windows.Forms.TextBox txtJenisPer;
        private System.Windows.Forms.Label lblJenisPer;
        private System.Windows.Forms.TextBox txtAlamatPer;
        private System.Windows.Forms.Label lblAlamatPer;
        private System.Windows.Forms.TextBox txtLimbahHasil;
        private System.Windows.Forms.Label lblLimbahHasil;
        private System.Windows.Forms.TextBox txtLimbahKelola;
        private System.Windows.Forms.Label lblLimbahKelola;
        private System.Windows.Forms.TextBox txtLimbahSimpan;
        private System.Windows.Forms.Label lblLimbahSimpan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvListPer;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblCari;
    }
}

