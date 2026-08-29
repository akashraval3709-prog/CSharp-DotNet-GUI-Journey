using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBDemo
{
    public partial class frmUpdate : Form
    {
        int RollNo;
        string Name, Gender, City;
        SqlConnection conn;
        public frmUpdate()
        {
            InitializeComponent();
        }


        private void updateData(string query)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RollNo", RollNo);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@City", City);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    DialogResult d =  MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(d == DialogResult.OK)
                    {
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Record not found with this Roll No!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public frmUpdate(int rollNo, string name, string gender, string city)
        {
            InitializeComponent();

            txtRollNo.Text = rollNo.ToString();
            txtRollNo.Enabled = false;
            txtName.Text = name ?? string.Empty;
            txtCity.Text = city ?? string.Empty;
            if (!string.IsNullOrEmpty(gender) && gender == "Male")
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text.Trim() == "" || txtCity.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RollNo =int.Parse( txtRollNo.Text);
            Name = txtName.Text.Trim();
            City = txtCity.Text.Trim();
            Gender = rdoMale.Checked ? "Male" : "Female";

            string query = "UPDATE tblStudent SET Name = @Name, Gender = @Gender, City = @City WHERE RollNo = @RollNo";
            updateData(query);

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRollNo.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtRollNo.Focus();

        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akash-.net\College_Practice\DBDemo\DBDemo\studentDb.mdf;Integrated Security=True";
            conn = new SqlConnection(str);
        }
    }
}
