using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DBDemo
{
    public partial class Form1 : Form
    {
        int RollNo;
        string Name, Gender, City;
        SqlConnection conn;
        SqlDataAdapter dt;
        DataTable db;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akash-.net\College_Practice\DBDemo\DBDemo\studentDb.mdf;Integrated Security=True";
            conn = new SqlConnection(str);
            LoadGrid();
        }

        private void LoadGrid()
        {
            dt = new SqlDataAdapter("SELECT * FROM tblStudent", conn);
            db = new DataTable();
            dt.Fill(db);
            dgvData.DataSource = db;

        }
        private void setData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RollNo", RollNo);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@City", City);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Add record : ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid(); 
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


        private void deleteData(string query)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure delete this record : ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text.Trim() != "")
            {
                RollNo = int.Parse(txtRollNo.Text);
              

            }
            else
            {

            }

            if (txtName.Text.Trim() != "")
            {
                Name = txtName.Text;

            }
            else
            {

            }

            if (rdoMale.Checked)
            {
                Gender = rdoMale.Text;
            }
            else
            {

            }

            if (rdoFemale.Checked)
            {
                Gender = rdoFemale.Text;
            }
            else
            {

            }
            if (txtCity.Text.Trim() != "")
            {
                City = txtCity.Text;

            }
            else
            {

            }


            string query = $"INSERT INTO tblStudent (RollNo, Name, Gender, City) VALUES(@RollNo,@Name,@Gender,@City)";
            setData(query);
            txtRollNo.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtRollNo.Focus();
            LoadGrid();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int roll = int.Parse(dgvData.SelectedRows[0].Cells[0].Value.ToString());

            string query = "DELETE FROM tblStudent WHERE RollNo =" + roll;
            deleteData(query);
            LoadGrid();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

           
                txtRollNo.Text = dgvData.SelectedRows[0].Cells[0].Value.ToString();
                txtRollNo.Enabled = false;
                txtName.Text = dgvData.SelectedRows[0].Cells[1].Value.ToString();
                String gen = dgvData.SelectedRows[0].Cells[2].Value.ToString();
                if (gen == "Male")
                {
                    rdoMale.Checked = true;
                }
                else
                {
                    rdoFemale.Checked = true;
                }
                txtCity.Text = dgvData.SelectedRows[0].Cells[3].Value.ToString();
                if (txtRollNo.Text.Trim() != "")
                {
                    RollNo = int.Parse(txtRollNo.Text);


                }
                else
                {

                }

                if (txtName.Text.Trim() != "")
                {
                    Name = txtName.Text;

                }
                else
                {

                }

                if (rdoMale.Checked)
                {
                    Gender = rdoMale.Text;
                }
                else
                {

                }

                if (rdoFemale.Checked)
                {
                    Gender = rdoFemale.Text;
                }
                else
                {

                }
                if (txtCity.Text.Trim() != "")
                {
                    City = txtCity.Text;

                }
                else
                {
           
                }


                string query = "UPDATE tblStudent SET Name = @Name, Gender = @Gender, City = @City WHERE RollNo = @RollNo";
                setData(query);
                txtRollNo.Text = "";
                txtName.Text = "";
                txtCity.Text = "";
                rdoMale.Checked = false;
                rdoFemale.Checked = false;
                txtRollNo.Focus();
                LoadGrid();






            }
            catch
            {
                MessageBox.Show("ERROR : Select any one row", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}

