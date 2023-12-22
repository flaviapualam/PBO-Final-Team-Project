using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PBO.PerClasses
{
    internal class PerClass
    {
        public int IDPer { get; set; }
        public string NamaPer { get; set; }
        public string SektorPer { get; set; }
        public string JenisPer { get; set; }
        public string AlamatPer { get; set; }
        public string LimbahHasil { get; set; }
        public string LimbahKelola { get; set; }
        public string LimbahSimpan { get; set; }

        static string myconnstrng = @"Data Source=LAPTOP-UOVIFQNV\SQLEXPRESS;Initial Catalog=WasteWin;Integrated Security=True;TrustServerCertificate=True;";

        //Select Data from database
        public DataTable Select()
        {
            //Database connection
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-UOVIFQNV\SQLEXPRESS;Initial Catalog=WasteWin;Integrated Security=True;TrustServerCertificate=True;");
            DataTable dt = new DataTable();
            try
            {
                //Writting SQL Query
                string sql = "SELECT * FROM tbl_perusahaan";
                //create cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create sql dataadapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex) 
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
     //insert data to database
     public bool Insert (PerClass c)
        {
            //create a default return type and set value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-UOVIFQNV\SQLEXPRESS;Initial Catalog=WasteWin;Integrated Security=True;TrustServerCertificate=True;");
            try
            {
                //create sql query to insert data
                string sql = "INSERT INTO tbl_perusahaan (NamaPer, SektorPer, JenisPer, AlamatPer, LimbahHasil, LimbahKelola, LimbahSimpan) VALUES (@NamaPer, @SektorPer, @JenisPer, @AlamatPer, @LimbahHasil, @LimbahKelola, @LimbahSimpan) ";
                //create sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@NamaPer", c.NamaPer);
                cmd.Parameters.AddWithValue("@SektorPer", c.SektorPer);
                cmd.Parameters.AddWithValue("@JenisPer", c.JenisPer);
                cmd.Parameters.AddWithValue("@AlamatPer", c.AlamatPer);
                cmd.Parameters.AddWithValue("@LimbahHasil", c.LimbahHasil);
                cmd.Parameters.AddWithValue("@LimbahKelola", c.LimbahKelola);
                cmd.Parameters.AddWithValue("@LimbahSimpan", c.LimbahSimpan);

                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then value of rows will be greater than zero else value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        
        //method to update data in database from app
        public bool Update(PerClass c)
        {
            //create a default return type and set value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-UOVIFQNV\SQLEXPRESS;Initial Catalog=WasteWin;Integrated Security=True;TrustServerCertificate=True;");
            try
            {
                //sql to update data in database
                string sql = "UPDATE tbl_perusahaan SET NamaPer=@NamaPer, SektorPer=@SektorPer, JenisPer=@JenisPer, AlamatPer=@AlamatPer, LimbahHasil=@LimbahHasil, LimbahKelola=@LimbahKelola, LimbahSimpan=@LimbahSimpan WHERE IDPer=@IDPer";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameter to add value
                cmd.Parameters.AddWithValue("@NamaPer", c.NamaPer);
                cmd.Parameters.AddWithValue("@SektorPer", c.SektorPer);
                cmd.Parameters.AddWithValue("@JenisPer", c.JenisPer);
                cmd.Parameters.AddWithValue("@AlamatPer", c.AlamatPer);
                cmd.Parameters.AddWithValue("@LimbahHasil", c.LimbahHasil);
                cmd.Parameters.AddWithValue("@LimbahKelola", c.LimbahKelola);
                cmd.Parameters.AddWithValue("@LimbahSimpan", c.LimbahSimpan);
                cmd.Parameters.AddWithValue("@IDper", c.IDPer);
                //open database connection
                conn.Open();

                int rows=cmd.ExecuteNonQuery();
                //if query runs sucessfully, value of rows will be greater than zero else value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Method to Delete data 
        public bool Delete(PerClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-UOVIFQNV\SQLEXPRESS;Initial Catalog=WasteWin;Integrated Security=True;TrustServerCertificate=True;");
            try
            {
                string sql = "DELETE FROM tbl_perusahaan WHERE IDPer=@IDPer";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDPer", c.IDPer);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
