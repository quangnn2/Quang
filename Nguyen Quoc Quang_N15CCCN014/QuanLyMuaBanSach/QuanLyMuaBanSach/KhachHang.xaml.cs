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
    /// Interaction logic for KhachHang.xaml
    /// </summary>
    public partial class KhachHang : Window
    {
        public KhachHang()
        {
            InitializeComponent();
            GetData();
        }
       
                    QuanlysachDataContext db = new QuanlysachDataContext();
        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int rowindex= datagrid.SelectedIndex;
            if (rowindex == -1)
            {
                return;
            }
            else
            {
                khachHang kh = (khachHang)datagrid.SelectedItem;
                tblKhachhang.Text = kh.TenKhachHang;
                tblDiachi.Text = kh.DiaChi;
                tblSdt.Text = kh.SoDienthoai.ToString();
                tblEmail.Text = kh.Email;
                tblId.Text = kh.ID.ToString();
                pdNgay.Text = kh.NgaySinh.ToString();
            }
          
            
        }
        private void GetData()
        {


            var khanhHangTable = from item in db.GetTable<khachHang>() select item;
            datagrid.ItemsSource = khanhHangTable;
            tblKhachhang.Clear();
            tblDiachi.Clear();
            tblEmail.Clear();
            tblSdt.Clear();
            pdNgay.Text = "";

        }


        private void Button_Click_Them(object sender, RoutedEventArgs e)
        {
           ThemKhachHang();
            GetData();
        }

        private void ThemKhachHang()
        {
            if (tblKhachhang.Text == "" || tblDiachi.Text == "" || tblEmail.Text == "" || tblSdt.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            khachHang kh = new khachHang();
                    kh.TenKhachHang = tblKhachhang.Text;
                    kh.DiaChi = tblDiachi.Text;
                    kh.SoDienthoai = int.Parse(tblSdt.Text);
                    kh.NgaySinh = DateTime.Parse(pdNgay.Text);
                    kh.Email = tblEmail.Text;
                    db.khachHangs.InsertOnSubmit(kh);
                    db.SubmitChanges();
            MessageBox.Show("Thêm thành công");
        }


        private void Button_Click_Sua(object sender, RoutedEventArgs e)
        {
           SuaKhachHang();
            GetData();
        }
        private void SuaKhachHang()
        {
            if (tblDiachi.Text == "" || tblKhachhang.Text == "" || tblEmail.Text == "" || tblSdt.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một dòng để sửa");
                return;
            }
                khachHang kh = db.khachHangs.Single(item => item.ID == int.Parse(tblId.Text));
                kh.TenKhachHang = tblKhachhang.Text;
                kh.SoDienthoai = int.Parse(tblSdt.Text);
                kh.DiaChi = tblDiachi.Text;
                kh.Email = tblEmail.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công");
        }

        private void Button_Click_Xoa(object sender, RoutedEventArgs e)
        {
            XoaKhachHang();
            GetData();

        }
        private void XoaKhachHang()
        {
            try
            {
                if (tblDiachi.Text == "" || tblKhachhang.Text == "" || tblEmail.Text == "" || tblSdt.Text == "")
                {
                    MessageBox.Show("Bạn phải chọn một dòng để xóan");
                    return;
                }
                khachHang kh = db.khachHangs.Single(item => item.ID == int.Parse(tblId.Text));
                db.khachHangs.DeleteOnSubmit(kh);
                db.SubmitChanges();
                MessageBox.Show("Xóa thanh công");
            }
            catch (Exception )
            {
                MessageBox.Show("Không được xóa");
            }

        }
    }

}

  