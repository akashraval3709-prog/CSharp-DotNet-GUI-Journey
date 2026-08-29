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
            if (txtRollNo.Text.Trim() != "" || txtName.Text.Trim() != "" || txtCity.Text.Trim() != "")
            {
                RollNo = int.Parse(txtRollNo.Text);
                Name = txtName.Text;
                City = txtCity.Text;


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

            Gender = rdoMale.Checked ? "Male" : "Female";



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



        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {

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

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.ColumnIndex.ToString() == "5")
            {

                try
                {




                    int roll = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());

                    string query = "DELETE FROM tblStudent WHERE RollNo =" + roll;
                    deleteData(query);
                    LoadGrid();
                    /* }
                     else
                     {
                         MessageBox.Show("Select any one row", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            if (e.ColumnIndex.ToString() == "6")
            {
                try
                {

                    int roll = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
                    string name = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string gender = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string city = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();

                    frmUpdate updateForm = new frmUpdate(roll, name, gender, city);
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
