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
    /// Interaction logic for TheLoai.xaml
    /// </summary>
    public partial class TheLoai : Window
    {
        public TheLoai()
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
                theLoai tg = (theLoai)datagrid.SelectedItem;
                tblId.Text = tg.ID.ToString();
                tblTheLoai.Text = tg.TheLoai;
            }
        }
        private void GetData()
        {
            var theLoaiTable = from item in db.GetTable<theLoai>() select item;
            datagrid.ItemsSource = theLoaiTable;
            tblId.Clear();
            tblTheLoai.Clear();
        }
        private void btThem(object sender, RoutedEventArgs e)
        {
            ThemtheLoai();
            GetData();
           
        }
        private void ThemtheLoai()
        {
            if (tblTheLoai.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            else
            {
                theLoai tg = new theLoai();
                tg.TheLoai = tblTheLoai.Text;
                db.theLoais.InsertOnSubmit(tg);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm thành công ");
            }
          
        }


        private void btSua(object sender, RoutedEventArgs e)
        {
            SuatheLoai();
            GetData();
          
        }
        private void SuatheLoai()
        {
            if (tblTheLoai.Text == "")
            {
                MessageBox.Show("Phải chọn thông tin cần sửa");
                return;
            }
            else
            {
                theLoai tg = db.theLoais.Single(item => item.ID == int.Parse(tblId.Text));
                tg.TheLoai = tblTheLoai.Text;
                MessageBox.Show("Đã sửa thành công ");
            }


        }

        private void btXoa(object sender, RoutedEventArgs e)
        {
            XoatheLoai();
            GetData();

        }
        private void XoatheLoai()
        {
            try
            {
                if (tblTheLoai.Text == "")
                {
                    MessageBox.Show("Phải chọn thông tin cần xóa");
                    return;
                }
                    theLoai tg = db.theLoais.Single(item => item.ID == int.Parse(tblId.Text));
                db.theLoais.DeleteOnSubmit(tg);
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
