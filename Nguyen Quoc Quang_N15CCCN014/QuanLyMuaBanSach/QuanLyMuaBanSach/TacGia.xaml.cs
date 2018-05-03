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
    /// Interaction logic for TacGia.xaml
    /// </summary>
    public partial class TacGia : Window
    {
        public TacGia()
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
                tacGia tg = (tacGia)datagrid.SelectedItem;
                tblId.Text =tg.ID.ToString() ;
               tblTacGia.Text = tg.TenTacGia;
            }
        }
        private void GetData()
        {
            var tacGiaTable = from item in db.GetTable<tacGia>() select item;
            datagrid.ItemsSource = tacGiaTable;
            tblId.Clear();
            tblTacGia.Clear();
        }


        private void btThem(object sender, RoutedEventArgs e)
        {
            ThemtacGia();
            GetData();
        }

        private void ThemtacGia()
        {
            if (tblTacGia.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
                    tacGia tg = new tacGia();
                    tg.TenTacGia = tblTacGia.Text;
                    db.tacGias.InsertOnSubmit(tg);
                    db.SubmitChanges();
                     MessageBox.Show("Đã thêm thành công ");
        }


        private void btSua(object sender, RoutedEventArgs e)
        {
            SuatacGia();
            GetData();
        }
        private void SuatacGia()
        {
            if (tblTacGia.Text == "")
            {
                MessageBox.Show("Phải chọn một dòng cần sửa");
                return;
            }
            tacGia tg = db.tacGias.Single(item => item.ID == int.Parse(tblId.Text));
                tg.TenTacGia = tblTacGia.Text;
                db.SubmitChanges();
                MessageBox.Show("Đã sửa thành công ");
        }

        private void btXoa(object sender, RoutedEventArgs e)
        {
            XoaTacGia();
            GetData();

        }
        private void XoaTacGia()
        {
            try
            {
                if (tblTacGia.Text == "")
                {
                    MessageBox.Show("Phải chọn  một dòng cần xóa");
                    return;
                }
                tacGia tg = db.tacGias.Single(item => item.ID == int.Parse(tblId.Text));
                db.tacGias.DeleteOnSubmit(tg);
                db.SubmitChanges();
                MessageBox.Show("Đã xóa thành công ");


            }
            catch (Exception)
            {
                MessageBox.Show("Không được xóa");
            }
        }
    }
}
