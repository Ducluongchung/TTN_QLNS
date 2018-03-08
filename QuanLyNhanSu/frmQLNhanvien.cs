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

namespace QuanLyNhanSu
{
    public partial class frmQLNhanvien : Form
    {
        SqlConnection conn;
        public void ketnoi()
        {
            string strConn = @"Data Source=DOAN-PC\SQLEXPRESS;Initial Catalog=QUANLYNHANVIEN;Integrated Security=True";
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        private void Show_Nhanvien(string mapb)
        {
            ketnoi();
            string sql = " Select MANV ,HOTEN as Hoten,NGAYSINH ,GIOITINH ,TENPB ,Diachi,LUONG From nhanvien INNER JOIN dbo.Phongban ON phongban.Mapb = NhanVien.Mapb";
            if (mapb != "")
                sql = sql + " Where mapb='" + mapb + "'";
            SqlDataAdapter daNhanvien = new SqlDataAdapter(sql, conn);
            DataTable dt1 = new DataTable();
            daNhanvien.Fill(dt1);
            DgvNhanVien.DataSource = dt1;
            DgvNhanVien.AutoResizeColumns();
        }
        private void Show_PhongBan(string mapb)
        {
            ketnoi();
            string sql = "Select MapB,TenPB from PhongBan";
            if (mapb != "")
                sql = sql + " Where mapb='" + mapb + "'";
            SqlDataAdapter daPB = new SqlDataAdapter(sql, conn);
            DataTable dt1 = new DataTable();
            daPB.Fill(dt1);
            cbMaPB.DataSource = dt1;
            cbMaPB.ValueMember = "MAPB";
            cbMaPB.DisplayMember = "TENPB";
        }
        public void Them_NV()
        {
            ketnoi();
            SqlCommand cmd = new SqlCommand("SP_ThemNV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaNV", txtMaNV.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Hoten", txtTenNV.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@diachi", txtDC.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MaPB", cbMaPB.SelectedValue.ToString());
            cmd.Parameters.Add(p);
            p = new SqlParameter("@luong", Convert.ToString(txtLuong.Text));
            if (radioButtonNam.Checked)
            {
                p = new SqlParameter("@GIOITINH", Convert.ToBoolean(radioButtonNam.Text));
                cmd.Parameters.Add(p);

            }
            else
            {
                p = new SqlParameter("@GIOITINH",Convert.ToBoolean(radioButtonNu.Text));
                cmd.Parameters.Add(p);
            }
            p = new SqlParameter("@NGAYSINH",dateTimePickerNV.Value.ToString());
            cmd.Parameters.Add(p);
            cmd.ExecuteNonQuery();
        }
        public frmQLNhanvien()
        {
            InitializeComponent();
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuyPB_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
        
        private void frmQLNhanvien_Load(object sender, EventArgs e)
        {
            Show_Nhanvien("");
            Show_PhongBan("");
        }

        private void DgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            Them_NV();
            Show_Nhanvien("");
        }
    }
}
