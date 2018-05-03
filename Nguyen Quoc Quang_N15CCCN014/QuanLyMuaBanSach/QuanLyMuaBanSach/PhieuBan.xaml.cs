using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyMuaBanSach
{
    /// <summary>
    /// Interaction logic for PhieuBan.xaml
    /// </summary>
    public partial class PhieuBan : Window
    {
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thongkephieuxuat frm = new Thongkephieuxuat();
            frm.ShowDialog();
        }
        public PhieuBan()
        {
            InitializeComponent();
            GetData();
        }
        QuanlysachDataContext db = new QuanlysachDataContext();

        public object MessageBoxButtons { get; private set; }
        public object MessageBoxIcon { get; private set; }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int rowindex = datagrid.SelectedIndex;
            if (rowindex == -1)
            {
                return;
            }
            else
            {
                var nhacungcapTable1 = from item in db.GetTable<nhaCungCap>() select item;
                var nhacungcapTable2 = from item in db.GetTable<theLoai>() select item;
                var nhacungcapTable3 = from item in db.GetTable<tacGia>() select item;
                chiTietBan ctb = (chiTietBan)datagrid.SelectedItem;
                tblId.Text = ctb.ID;
                tblGia.Text = ctb.Gia.ToString();
                cbTenSach.SelectedValue = ctb.MaSach;
                tblSoLuong.Text = ctb.SoLuong. ToString();
                pdNgay.Text = ctb.NgayBan.ToString();
                cbKhachHang.SelectedValue = ctb.IDKhachHang;
            }
        }
        private void GetData()
        {
            var chitietbaTable = from item in db.GetTable<chiTietBan>() select item;
            datagrid.ItemsSource = chitietbaTable;
            tblId.Clear();
            cbTenSach.Text = "";
            tblSoLuong.Text = "";
            tblSoLuong.Text = "";
            tblGia.Text = "";
            cbKhachHang.Text = "";
            pdNgay.Text = "";
            var sachTable = from item in db.GetTable<sach>() select item;
            cbTenSach.ItemsSource = sachTable;
            cbTenSach.DisplayMemberPath = "TenSach";
            cbTenSach.SelectedValuePath = "MaSach";
            var khachhangTable = from item in db.GetTable<khachHang>() select item;
            cbKhachHang.ItemsSource = khachhangTable;
            cbKhachHang.DisplayMemberPath = "TenKhachHang";
            cbKhachHang.SelectedValuePath = "ID";

        }


        private void btThem(object sender, RoutedEventArgs e)
        {
          ThemPhieuBan();
            GetData();
        }

        private void ThemPhieuBan()
        {
           
                if (tblGia.Text == "" || tblId.Text == "" || tblSoLuong.Text == "" || cbKhachHang.Text == "" || cbTenSach.Text == "" || pdNgay.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                    return;
                }
            List<chiTietBan> data = db.chiTietBans.Where(t => t.ID == tblId.Text).ToList();

            if (data.Count > 0)
            {
                MessageBox.Show("mã phiếu đã  tồn tại");
                return;
            }
            else
            {
                chiTietBan ctb = new chiTietBan();
                ctb.ID = tblId.Text;
                ctb.SoLuong = int.Parse(tblSoLuong.Text);
                ctb.MaSach = cbTenSach.SelectedValue.ToString();
                ctb.IDKhachHang = int.Parse(cbKhachHang.SelectedValue.ToString());
                ctb.Gia = float.Parse(tblGia.Text);
                ctb.NgayBan = DateTime.Parse(pdNgay.Text);
                db.chiTietBans.InsertOnSubmit(ctb);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
            }


        }



        private void btSua(object sender, RoutedEventArgs e)
        {
            SuaPhieuBan();
            GetData();
        }
        private void SuaPhieuBan()
        {
            if (tblGia.Text == "" || tblId.Text == "" || tblSoLuong.Text == "" || cbKhachHang.Text == "" || cbTenSach.Text == "" || pdNgay.Text == "")
            {
                MessageBox.Show("Phải chọn một dòng để sửa");
                return;
            }
            chiTietBan ctb = db.chiTietBans.Single(item => item.ID == tblId.Text);
                ctb.ID = tblId.Text;
                ctb.SoLuong = int.Parse(tblSoLuong.Text);
                ctb.MaSach = cbTenSach.SelectedValue.ToString();
                ctb.IDKhachHang = int.Parse(cbKhachHang.SelectedValue.ToString());
                ctb.Gia = float.Parse(tblGia.Text);
                ctb.NgayBan = DateTime.Parse(pdNgay.Text);
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công");

        }

        private void btXoa(object sender, RoutedEventArgs e)
        {
            XoaPhieuBan();
            GetData();

        }
        private void XoaPhieuBan()
        {
            
            try
            {
                if (tblGia.Text == "" || tblId.Text == "" || tblSoLuong.Text == "" || cbKhachHang.Text == "" || cbTenSach.Text == "" || pdNgay.Text == "")
                {
                    MessageBox.Show("Phải chọn một dòng để  xóa");
                    return;
                }
                chiTietBan ctb = db.chiTietBans.Single(item => item.ID == tblId.Text);
                db.chiTietBans.DeleteOnSubmit(ctb);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công");
            }
           
            catch (Exception)
            {
                MessageBox.Show("Không được xóa");
            }
           
        }
    }
}
