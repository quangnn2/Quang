using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyMuaBanSach
{
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
         
        }
     

        private void Button_Click_Sach(object sender, RoutedEventArgs e)
        {
            Sach frm = new Sach();
            frm.ShowDialog();
        }

        private void Button_Click_Khachhang(object sender, RoutedEventArgs e)
        {
            KhachHang frm = new KhachHang();
            frm.ShowDialog();
        }

        private void Button_Click_Nhacungcap(object sender, RoutedEventArgs e)
        {
            NhaCungCap frm = new NhaCungCap();
            frm.ShowDialog();
        }

        private void Button_Click_Phieunhap(object sender, RoutedEventArgs e)
        {
            PhieuNhap frm = new PhieuNhap();
            frm.ShowDialog();
        }

        private void Button_Click_Phieuban(object sender, RoutedEventArgs e)
        {
            PhieuBan frm = new PhieuBan();
            frm.ShowDialog();

        }

        private void Button_Click_Tac_Gia(object sender, RoutedEventArgs e)
        {
            TacGia frm = new TacGia();
            frm.ShowDialog();
        }

        private void Button_Click_The_Loai(object sender, RoutedEventArgs e)
        {
            TheLoai frm = new TheLoai();
            frm.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tonkho frm = new Tonkho();
            frm.ShowDialog();
        }
    }
}
