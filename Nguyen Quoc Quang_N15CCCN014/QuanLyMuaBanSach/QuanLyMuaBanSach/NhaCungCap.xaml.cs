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
    /// Interaction logic for NhaCungCap.xaml
    /// </summary>
    public partial class NhaCungCap : Window
    {
        public NhaCungCap()
        {
            InitializeComponent();
            GetData();
           
        }

        QuanlysachDataContext db = new QuanlysachDataContext();
        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int rowindex = datagrid.SelectedIndex;
            if(rowindex==-1)
            {
                return;
            }
            else
            {
                nhaCungCap kh = (nhaCungCap)datagrid.SelectedItem;
                tblNhaCungCap.Text = kh.TenNhaCungCap;
                tblDiaChi.Text = kh.DiaChi;
                tblSdt.Text = kh.SoDienThoai.ToString();
                tblEmail.Text = kh.Email;
                tblId.Text = kh.ID.ToString();
            }
           
          

        }
        private void GetData()
        {


            var nhacungcapTable= from item in db.GetTable<nhaCungCap>() select item;
            datagrid.ItemsSource = nhacungcapTable;
            tblId.Clear();
            tblNhaCungCap.Clear();
            tblDiaChi.Clear();
            tblEmail.Clear();
            tblSdt.Clear();

        }


        private void btThem(object sender, RoutedEventArgs e)
        {
            ThemNhaCungCap();
            GetData();
        }

        private void ThemNhaCungCap()
        {
            if( tblNhaCungCap.Text=="" || tblDiaChi.Text=="" || tblEmail.Text=="" || tblSdt.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
              nhaCungCap ncc = new nhaCungCap();
                    ncc.TenNhaCungCap= tblNhaCungCap.Text;
                    ncc.DiaChi = tblDiaChi.Text;
                    ncc.SoDienThoai = int.Parse(tblSdt.Text);
                    ncc.Email = tblEmail.Text;
                    db.nhaCungCaps.InsertOnSubmit(ncc);
                    db.SubmitChanges();
            MessageBox.Show("Thêm thanh công");
        }


        private void btSua(object sender, RoutedEventArgs e)
        {
            SuaNhaCungCap();
            GetData();
        }
        private void SuaNhaCungCap()
        {
            if (tblNhaCungCap.Text == "" || tblDiaChi.Text == "" || tblEmail.Text == "" || tblSdt.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            nhaCungCap ncc = db.nhaCungCaps.Single(item => item.ID == int.Parse(tblId.Text));
                ncc.SoDienThoai = int.Parse(tblSdt.Text);
                ncc.DiaChi = tblDiaChi.Text;
                ncc.Email = tblEmail.Text;
                ncc.TenNhaCungCap = tblNhaCungCap.Text;
                db.SubmitChanges();
            MessageBox.Show("Sữa thành công");

        }

        private void btXoa(object sender, RoutedEventArgs e)
        {
            XoaNhaCungCap();
            GetData();

        }
        private void XoaNhaCungCap()
        {
            
                if (tblNhaCungCap.Text == "" || tblDiaChi.Text == "" || tblEmail.Text == "" || tblSdt.Text == "")
                {
                    MessageBox.Show("Bạn phải chọn một dòng để xóa");
                    return;
                }
                nhaCungCap ncc = db.nhaCungCaps.Single(item => item.ID == int.Parse(tblId.Text));
                db.nhaCungCaps.DeleteOnSubmit(ncc);
                db.SubmitChanges();
            MessageBox.Show("Xóa thành công");
        }
    }
}
