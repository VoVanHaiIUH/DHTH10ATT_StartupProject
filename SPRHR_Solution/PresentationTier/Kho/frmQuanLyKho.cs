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
using BusinessEntities.NhanSu;

namespace PresentationTier.Kho
{
    public partial class frmQuanLyKho : Form
    {
        private int flagluu = 0;
        ThongTinKho_BUS ttkBUS;
        QuanLyKho_BUS qlkBUS;
        eThongTinKho eTTK;
        eQuanLyKho eQLK;
        public frmQuanLyKho()
        {
            InitializeComponent();
            ttkBUS = new ThongTinKho_BUS();
            eTTK = new eThongTinKho();
            qlkBUS = new QuanLyKho_BUS();
            eQLK = new eQuanLyKho();
        }

        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            LoadTreeView();
            LoaddsKho();
        }

        private void LoadTreeView()
        {
            try
            {
                tvDSkho.Nodes.Clear();
                foreach (eThongTinKho ettkho in ttkBUS.GetThongTinKho())
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

        private void LoaddsKho()
        {
            
            cbmakho.DataSource = ttkBUS.GetThongTinKho();
            cbmakho.DisplayMember = "tenKho";
            cbmakho.ValueMember = "maKho";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if(btnThem.Text == "Thêm")
            {
                txtchucvu.Enabled = true;
                cbmakho.Enabled = true;
                txtmanv.Enabled = true;
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                cbmakho.Enabled = true;
                flagluu = 1;
            }
            else
            {
                txtchucvu.Enabled = false;
                txtmanv.Enabled = false;
                cbmakho.Enabled = false;
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnsua.Enabled = true;
                cbmakho.Enabled = false;
                btnxoa.Enabled = true;
                flagluu = 0;
            }
        }

        private void tvDSkho_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string makho = e.Node.Tag.ToString();
            cbmakho.SelectedValue = makho;
            LoadDgv(makho);
        }

        private void LoadDgv(string ma)
        {
            try
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("manv",typeof(string));
                tb.Columns.Add("ten", typeof(string));
                tb.Columns.Add("chucvu",typeof(string));
                tb.Columns.Add("makho",typeof(string));
                tb.Columns.Add("sdt", typeof(string));
                
                foreach (eQuanLyKho eql in qlkBUS.GetNv(ma))
                {
                    DataRow r = tb.NewRow();
                    r["manv"] = eql.MaNV;
                    r["chucvu"] = eql.ChucVu;
                    r["makho"] = eql.MaKho;
                    foreach (eNhanVien env in qlkBUS.GetTTNhanVien(eql.MaNV))
                    {
                        r["ten"] = env.HoTenNhanVien;
                        r["sdt"] = env.SoDT;
                    }
                    tb.Rows.Add(r); 
                }
                dataGridView1.DataSource = tb;
            }
            catch
            {
                MessageBox.Show("Không thể load dGV");
            }
            
        }

        private void LoadTxt()
        {
            txtmanv.DataBindings.Clear();
            txtmanv.DataBindings.Add("text",dataGridView1.DataSource, "manv");
            txttennv.DataBindings.Clear();
            txttennv.DataBindings.Add("text", dataGridView1.DataSource, "ten");
            txtchucvu.DataBindings.Clear();
            txtchucvu.DataBindings.Add("text", dataGridView1.DataSource, "chucvu");
            cbmakho.DataBindings.Clear();
            cbmakho.DataBindings.Add("text", dataGridView1.DataSource, "makho");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           LoadTxt();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int flagbtnsua = int.Parse(btnsua.Tag.ToString());
            if(flagbtnsua == 0)
            {
                int count = dataGridView1.SelectedRows.Count;
                if(count < 1)
                { MessageBox.Show("Chưa chọn nhân viên để sửa"); }
                else if(count > 1)
                { MessageBox.Show("Chỉ chọn được 1 người"); }
                else
                {
                    btnThem.Enabled = false;
                    btnxoa.Enabled = false;
                    cbmakho.Enabled = false;
                    btnLuu.Enabled = true;
                    btnsua.Text = "Hủy";
                    btnsua.Tag = 1;
                    txtchucvu.Enabled = true;
                    cbmakho.Enabled = true;
                    flagluu = 2;
                }
            }
            else
            {
                btnThem.Enabled = true;
                btnxoa.Enabled = true;
                cbmakho.Enabled = true;
                btnLuu.Enabled = false;
                btnsua.Text = "Sửa";
                btnsua.Tag = 0;
                txtchucvu.Enabled = false;
                cbmakho.Enabled = false;
                flagluu = 0;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagluu == 1)
                {
                    eQuanLyKho eql = new eQuanLyKho();
                    eql.MaKho = cbmakho.SelectedValue.ToString();
                    eql.ChucVu = txtchucvu.Text;
                    eql.MaNV = txtmanv.Text;
                    if(qlkBUS.TaoNvKho(eql) == 1)
                    {
                        MessageBox.Show("Tạo thành công");
                        LoadDgv(cbmakho.Text);
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên đã nghỉ hoặc không có nhân viên này");
                    }
                    btnThem_Click(btnThem, new EventArgs());
                }
                else if (flagluu == 2)
                {
                    eQuanLyKho ql = new eQuanLyKho();
                    ql.MaKho = cbmakho.SelectedValue.ToString();
                    ql.ChucVu = txtchucvu.Text;

                    qlkBUS.SuaThongtinNvKho(ql);
                    MessageBox.Show("Thành công");
                    LoadTreeView();
                    LoaddsKho();
                    flagluu = 0;
                    btnsua_Click(btnsua, new EventArgs());
                }
            }
            catch
            {

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (qlkBUS.XoaNVKho(txtmanv.Text, cbmakho.SelectedValue.ToString()))
                {
                    MessageBox.Show("Đã xóa nhân viên mã" + txtmanv.Text);
                }
            }
        }

        private void cbmakho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
