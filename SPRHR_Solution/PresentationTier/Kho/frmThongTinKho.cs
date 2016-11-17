using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier.Kho;
using BusinessEntities.Kho;
using BusinessEntities.PhongKeHoach;

namespace PresentationTier.Kho
{
    public partial class frmThongTinKho_dal : Form
    {
        ThongTinKho_BUS ttkBUS;
        ChiTietKho_BUS ctkBUS;
        eThongTinKho eTTK;
        eChiTietKho ect;
        public frmThongTinKho_dal()
        {
            InitializeComponent();
            ttkBUS = new ThongTinKho_BUS();
            ctkBUS = new ChiTietKho_BUS();
            eTTK = new eThongTinKho();
            ect = new eChiTietKho();
        }

        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            LoadTreeView();
        }

        private void LoadDgv(string makho)
        {
            //ctkBUS.GetTTSP(makho,dg);
            try
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("masp", typeof(string));
                tb.Columns.Add("tensp", typeof(string));
                tb.Columns.Add("loaisp", typeof(string));
                tb.Columns.Add("soluong", typeof(string));
                tb.Columns.Add("mausac", typeof(string));
                tb.Columns.Add("ngaysanxuat", typeof(string));

                foreach (eChiTietKho ect in ctkBUS.GetSpByMakho(makho))
                {
                    DataRow r = tb.NewRow();
                    r["masp"] = ect.Masp;
                    r["soluong"] = ect.SoLuong;
                    foreach (eSanPham sp in ctkBUS.GetThongTinSp(ect.Masp))
                    {
                        r["tensp"] = sp.TenSP;
                        r["loaisp"] = sp.MaLoaiSP;
                        r["mausac"] = sp.MauSac;
                        r["ngaysanxuat"] = sp.NgaySX.ToShortDateString();
                    }
                    tb.Rows.Add(r);
                }
                dGVSP.DataSource = tb;
            }
            catch
            {
                MessageBox.Show("Không thể load dGV");
            }

        }

        private void LoadTreeView()
        {
            try
            {
                tvDSkho.Nodes.Clear();
                foreach(eThongTinKho ettkho in ttkBUS.GetThongTinKho())
                {
                    TreeNode tn = new TreeNode();
                    tn.Tag = ettkho.MaKho;
                    tn.Text = ettkho.TenKho;

                    tvDSkho.Nodes.Add(tn);
                }
            }
            catch
            {
                MessageBox.Show("Không thế load tree view");
            }
        }

        private void tvDSkho_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string ma = e.Node.Tag.ToString();
                txtmakho.Text = ma;
                foreach(eThongTinKho ettkho in ttkBUS.GetThongTinbyMa(ma))
                {
                    txtdiachi.Text = ettkho.DiaChi;
                    txtsdt.Text = ettkho.SDT;
                    txttenkho.Text = ettkho.TenKho;
                }
                LoadDgv(ma);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                dGVSP.ClearSelection();
                ctkBUS.search(txtmakho.Text, txttensp.Text,dGVSP);

                //LoadDgv(txtmakho.Text,txttensp.Text);
                
            }
            catch 
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
