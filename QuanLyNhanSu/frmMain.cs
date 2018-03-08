using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MnuThemNV_Click(object sender, EventArgs e)
        {
            
        }

        private void MnuThemPB_Click(object sender, EventArgs e)
        {
           
        }

        private void MnuThemDA_Click(object sender, EventArgs e)
        {
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhanvien nv = new frmQLNhanvien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLPhongBan nv = new frmQLPhongBan();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void dựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDuAn nv = new frmQLDuAn();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }
    }
}
