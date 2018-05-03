using System;
using System.Collections.Generic;
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
    /// Interaction logic for PhieuNhap.xaml
    /// </summary>
    public partial class PhieuNhap : Window
    {
        public PhieuNhap()
        {
            InitializeComponent();
            GetData();
        }
        QuanlysachDataContext db = new QuanlysachDataContext();

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
                chiTietNhap ctn1 = (chiTietNhap)datagrid.SelectedItem;
                tblId.Text = ctn1.ID;
                tblGia.Text = ctn1.Gia.ToString();
                cbTenSach.SelectedValue = ctn1.MaSach;
                tblSoLuong.Text = ctn1.SoLuong.ToString();
                pdNgay.Text = ctn1.NgayNhap.ToString();
                cbNahCungCap.SelectedValue = ctn1.IDNhaCungCap;
            }
        }
        private void GetData()
        {
            datagrid.ItemsSource = from ctn in db.GetTable<chiTietNhap>() select ctn;
            tblId.Clear();
            cbTenSach.Text = "";
            tblSoLuong.Text = "";
            tblSoLuong.Text = "";
            tblGia.Text = "";
            cbNahCungCap.Text = "";
            pdNgay.Text = "";
            var sachTable = from item in db.GetTable<sach>() select item;
            cbTenSach.ItemsSource = sachTable;
            cbTenSach.DisplayMemberPath = "TenSach";
            cbTenSach.SelectedValuePath = "MaSach";
            var khachhangTable = from item in db.GetTable<nhaCungCap>() select item;
            cbNahCungCap.ItemsSource = khachhangTable;
            cbNahCungCap.DisplayMemberPath = "TenNhaCungCap";
            cbNahCungCap.SelectedValuePath = "ID";

        }


        private void btThem(object sender, RoutedEventArgs e)
        {
            ThemPhieuNhap();
            GetData();
        }

        private void ThemPhieuNhap()
        {

                if (tblGia.Text == "" || tblId.Text == "" || tblSoLuong.Text == "" || cbNahCungCap.Text == "" || cbTenSach.Text == "" || pdNgay.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                    return;
                }
            List<chiTietNhap> data = db.chiTietNhaps.Where(t => t.ID == tblId.Text).ToList();

            if (data.Count > 0)
            {
                MessageBox.Show("mã phiếu đã  tồn tại");
                return;
            }
            else
            {
                chiTietNhap ctn = new chiTietNhap();
                ctn.ID = tblId.Text;
                ctn.SoLuong = int.Parse(tblSoLuong.Text);
                ctn.MaSach = cbTenSach.SelectedValue.ToString();
                ctn.IDNhaCungCap = int.Parse(cbNahCungCap.SelectedValue.ToString());
                ctn.Gia = float.Parse(tblGia.Text);
                ctn.NgayNhap = DateTime.Parse(pdNgay.Text);
                db.chiTietNhaps.InsertOnSubmit(ctn);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
            }
          

        }



        private void btSua(object sender, RoutedEventArgs e)
        {
            SuaNhaCungCap();
            GetData();
        }
        private void SuaNhaCungCap()
        {
            if (tblGia.Text == "" || tblId.Text == "" || tblSoLuong.Text == "" || cbNahCungCap.Text == "" || cbTenSach.Text == "" || pdNgay.Text == "")
            {
                MessageBox.Show("Phải chọn một  dong cần  sửa");
                return;
            }
            chiTietNhap ctn = db.chiTietNhaps.Single(item => item.ID == tblId.Text);
                ctn.ID = tblId.Text;
                ctn.SoLuong = int.Parse(tblSoLuong.Text);
                ctn.MaSach = cbTenSach.SelectedValue.ToString();
                ctn.IDNhaCungCap = int.Parse(cbNahCungCap.SelectedValue.ToString());
                ctn.Gia = float.Parse(tblGia.Text);
                ctn.NgayNhap = DateTime.Parse(pdNgay.Text);
                db.SubmitChanges();
                 MessageBox.Show("Sửa thành công");
        }

        private void btXoa(object sender, RoutedEventArgs e)
        {
            XoaNhaCungCap();
            GetData();

        }
        private void XoaNhaCungCap()
        {
            try
            {
                if (tblGia.Text == "" || tblId.Text == "" || tblSoLuong.Text == "" || cbNahCungCap.Text == "" || cbTenSach.Text == "" || pdNgay.Text == "")
                {
                    MessageBox.Show("Phải chọn một dòng cần xóa");
                    return;
                }
                chiTietNhap  ctn = db.chiTietNhaps.Single(item => item.ID == tblId.Text);
                db.chiTietNhaps.DeleteOnSubmit(ctn);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Không được xóa");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thongkephieunhap frm = new Thongkephieunhap();
            frm.ShowDialog();
        }
    }
}
