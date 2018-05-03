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
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn hủy bỏ ?", "xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            QuanlysachDataContext db = new QuanlysachDataContext();
            List<user> data = db.users.Where(t => t.TenDangNhap == txtTenDangNhap.Text && t.PassWord == pwbMatKhau.Password).ToList();
            {
                if (txtTenDangNhap.Text == "" || pwbMatKhau.Password == "")
                {
                    MessageBox.Show("Bạn hảy nhập đầy đủ thông tin từ cơ sở dữ liệu vào!", "Thông Báo");
                }
                else
                {
                    if (data.Count > 0)
                    {

                        //MessageBox.Show("Ban da dang nhap thanh cong !");
                        this.Hide();
                        MainWindow frmMain = new MainWindow();
                        frmMain.ShowDialog();

                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Ten dan nhap hay mat khau ban nhap khong dung !", "Thong Bao");
                        txtTenDangNhap.Focus();
                        pwbMatKhau.Focus();
                        return;
                    }
                }
            }

        }

    }
}
