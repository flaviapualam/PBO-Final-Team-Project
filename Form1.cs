using PBO.PerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PerClass c = new PerClass();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get value from input fields
            c.NamaPer = txtNamaPer.Text;
            c.SektorPer = txtSektorPer.Text;
            c.JenisPer = txtJenisPer.Text;
            c.AlamatPer = txtAlamatPer.Text;
            c.LimbahHasil = txtLimbahHasil.Text;
            c.LimbahKelola = txtLimbahKelola.Text;
            c.LimbahSimpan = txtLimbahSimpan.Text;

            //calculate limbah disimpan
            double textLimbahHasil = double.Parse(txtLimbahHasil.Text);
            double textLimbahKelola = double.Parse(txtLimbahKelola.Text);
            ComputeLimbahSimpan(textLimbahHasil, textLimbahKelola);

            //insert data into database
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Perusahaan Baru Berhasil Ditambahkan");
                //call the clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan Data Perusahaan. Coba Lagi.");
            }
            //load data on data grid view
            DataTable dt = c.Select();
            dgvListPer.DataSource = dt;
        }

        private void ComputeLimbahSimpan(double textLimbahHasil, double textLimbahKelola)
        {
            double textLimbahSimpan = textLimbahHasil - textLimbahKelola;

            txtLimbahSimpan.Text = textLimbahSimpan.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //load data on data grid view
            DataTable dt = c.Select();
            dgvListPer.DataSource = dt;
        }
        //method to clear fields
        public void Clear()
        {
            txtIDPer.Text = "";
            txtNamaPer.Text = "";
            txtSektorPer.Text = "";
            txtJenisPer.Text = "";
            txtAlamatPer.Text = "";
            txtLimbahHasil.Text = "";
            txtLimbahKelola.Text = "";
            txtLimbahSimpan.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get data from txtbox
            c.IDPer = int.Parse(txtIDPer.Text);
            c.NamaPer = txtNamaPer.Text;
            c.SektorPer = txtSektorPer.Text;
            c.JenisPer = txtJenisPer.Text;
            c.AlamatPer = txtAlamatPer.Text;
            c.LimbahHasil = txtLimbahHasil.Text;
            c.LimbahKelola = txtLimbahKelola.Text;
            c.LimbahSimpan = txtLimbahSimpan.Text;

            //calculate limbah disimpan
            double textLimbahHasil = double.Parse(txtLimbahHasil.Text);
            double textLimbahKelola = double.Parse(txtLimbahKelola.Text);

            double LimbahSimpan = textLimbahHasil - textLimbahKelola;

            txtLimbahSimpan.Text = LimbahSimpan.ToString();

            //update data in database
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Data Berhasil Diupdate.");
                //load data on data grid view
                DataTable dt = c.Select();
                dgvListPer.DataSource = dt;
                //call clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Data Gagal Diupdate. Coba lagi.");
            }
        }

        private void dgvListPer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data from data grid view and load to the txtbox respectively
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtIDPer.Text = dgvListPer.Rows[rowIndex].Cells[0].Value.ToString();
            txtNamaPer.Text = dgvListPer.Rows[rowIndex].Cells[1].Value.ToString();
            txtSektorPer.Text = dgvListPer.Rows[rowIndex].Cells[2].Value.ToString();
            txtJenisPer.Text = dgvListPer.Rows[rowIndex].Cells[3].Value.ToString();
            txtAlamatPer.Text = dgvListPer.Rows[rowIndex].Cells[4].Value.ToString();
            txtLimbahHasil.Text = dgvListPer.Rows[rowIndex].Cells[5].Value.ToString();
            txtLimbahKelola.Text = dgvListPer.Rows[rowIndex].Cells[6].Value.ToString();
            txtLimbahSimpan.Text = dgvListPer.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call clear method here
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get Idperusahaan from app
            c.IDPer = (int)Convert.ToInt64(txtIDPer.Text);
            bool success = c.Delete(c);
            if(success == true)
            {
                MessageBox.Show("Data Berhasil Dihapus.");
                DataTable dt = c.Select();
                dgvListPer.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Data Gagal Dihapus. Coba Lagi.");
            }
        }
        static string myconnstring = @"Data Source=LAPTOP-UOVIFQNV\SQLEXPRESS;Initial Catalog=WasteWin;Integrated Security=True;TrustServerCertificate=True;";
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            //get value from textbox
            string keyword = txtCari.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-UOVIFQNV\SQLEXPRESS;Initial Catalog=WasteWin;Integrated Security=True;TrustServerCertificate=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_perusahaan WHERE NamaPer LIKE '%" + keyword + "%' OR SektorPer LIKE '%" + keyword + "%' OR JenisPer LIKE '%" + keyword+"%' OR AlamatPer LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvListPer.DataSource = dt;
        }
    }
}
