using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBDemo
{
    public partial class From1 : Form
    {
        int RollNo;
        string Name, Gender, City, DateOfBirth;
        SqlConnection conn;
        SqlDataAdapter dt;
        DataTable db;

        public From1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akash-.net\College_Practice\DBDemo\DBDemo\studentDb.mdf;Integrated Security=True";
            conn = new SqlConnection(str); 
            dgvData.AllowUserToAddRows = false;


            CreateTableIfNotExists();

           
            LoadGrid();
        }

      
        private void CreateTableIfNotExists()
        {
            try
            {
                string createTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tblStudent')
                    BEGIN
                        CREATE TABLE tblStudent (
                            RollNo INT PRIMARY KEY,
                            Name NVARCHAR(100) NOT NULL,
                            Gender NVARCHAR(10) NOT NULL,
                            City NVARCHAR(100) NOT NULL,
                            DateOfBirth DATE NOT NULL,
                            [Delete] VARCHAR(10) NOT NULL DEFAULT 'Delete',
                    [Update] VARCHAR(10) NOT NULL DEFAULT 'Update'
                        )
                    END";

                SqlCommand cmd = new SqlCommand(createTableQuery, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Table Creation Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void LoadGrid()
        {
            try
            {
                dt = new SqlDataAdapter("SELECT * FROM tblStudent", conn);
                db = new DataTable();
                dt.Fill(db);
                dgvData.DataSource = db;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grid Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added record!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void deleteData(string query)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text.Trim() != "" && txtName.Text.Trim() != "" && txtCity.Text.Trim() != "")
            {
                RollNo = int.Parse(txtRollNo.Text.Trim());
                Name = txtName.Text.Trim();
                City = txtCity.Text.Trim();

                int age = DateTime.Today.Year - dtBrithDate.Value.Year;

                if (age < 15)
                {
                    MessageBox.Show("Student age must be at least 15 years!", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtBrithDate.Focus();
                    return;
                }
                else
                {
                    DateOfBirth = dtBrithDate.Value.ToString("yyyy-MM-dd");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Gender = rdoMale.Checked ? "Male" : "Female";

            try
            {
                string query = "INSERT INTO tblStudent (RollNo, Name, Gender, City, DateOfBirth) VALUES (@RollNo, @Name, @Gender, @City, @DateOfBirth)";
                setData(query);

                btnClear_Click(sender, e);
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRollNo.Clear();
            txtName.Clear();
            txtCity.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            dtBrithDate.Value = DateTime.Today;
            txtRollNo.Focus();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Delete Click (Column Index 5)
                if (e.ColumnIndex == 5)
                {
                    try
                    {
                        int roll = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
                        string query = "DELETE FROM tblStudent WHERE RollNo = " + roll;
                        deleteData(query);
                        LoadGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Update Click (Column Index 6)
                if (e.ColumnIndex == 6)
                {
                    try
                    {
                        int roll = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
                        string name = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string gender = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string city = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string date = dgvData.Rows[e.RowIndex].Cells[4].Value.ToString();

                        frmUpdate updateForm = new frmUpdate(roll, name, gender, city, date);
                        updateForm.ShowDialog();

                        LoadGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
