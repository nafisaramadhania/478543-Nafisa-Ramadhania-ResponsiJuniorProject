using Npgsql;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=Responsi2";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                dgv.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgv.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, " FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgv.Rows[e.RowIndex];
                tbNamaKaryawan.Text = r.Cells[":_nama"].Value.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sql = @"select * from st_insert(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil di-input", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNamaKaryawan = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan di-update", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();

                sql = @"select * from st_update(:_id_karyawan, :_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNamaKaryawan = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) 
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan di-delete", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar Anda ingin menghapus data" + r.Cells["_nama"].Value.ToString() + "?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    sql = @"select * from st_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data berhasil dihapus!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoad.PerformClick();
                        tbNamaKaryawan = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Update FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
