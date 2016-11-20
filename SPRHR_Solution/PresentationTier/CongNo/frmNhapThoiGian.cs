using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier.CongNo
{
    public partial class frmNhapThoiGian : Form
    {
        private ThoiGian TG = null;
        public frmNhapThoiGian()
        {
            InitializeComponent();
        }
        public ThoiGian GetThoiGian()
        {
            return TG;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult dlr = new DialogResult();
            if (dateNgayKetThuc.Value.CompareTo(DateTime.Now) == 1)
            {
                dlr = MessageBox.Show("Ngày kết thúc vượt quá ngày hiện tại đồng ý chứ","",MessageBoxButtons.YesNo);
                if (dlr == DialogResult.No)
                    return;
            }
            if (dateNgayBatDau.Value.CompareTo(dateNgayKetThuc.Value) == 0)
            {
                dlr = MessageBox.Show("Ngày bắt đầu trùng với ngày kêt thúc đồng ý chứ", "", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.No)
                    return;
            }
            if (dateNgayBatDau.Value.CompareTo(dateNgayKetThuc.Value) == 1)
            {
                dlr = MessageBox.Show("Ngày bắt đầu vượt quá ngày kêt thúc ");
                return;
            }
            TG = new ThoiGian();
            TG.NgayBatDau = dateNgayBatDau.Value;
            TG.NgayKetThuc = dateNgayKetThuc.Value;
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
