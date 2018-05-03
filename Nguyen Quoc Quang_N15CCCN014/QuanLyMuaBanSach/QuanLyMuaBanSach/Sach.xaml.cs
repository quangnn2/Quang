using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
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
   
        public partial class Sach : Window
        {
        QuanlysachDataContext db = new QuanlysachDataContext();
      
        public Sach()
        {
            InitializeComponent();
            GetData();
        }
       

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
                sach sa = (sach)datagrid.SelectedItem;
                tblId.Text = sa.MaSach;
                tblTenSach.Text = sa.TenSach;
                cbTacgia.SelectedValue = sa.IDTacGia;
                cbTheloai.Text = sa.theLoai.TheLoai;
            }



        }
        private void GetData()
        {
            var sachTable = from item in db.GetTable<sach>() select item;
            datagrid.ItemsSource = sachTable;
            tblId.Clear();
            tblTenSach.Clear();
            cbTheloai.Text = "";
            cbTacgia.Text = "";var khanhHangTable = from item in db.GetTable<tacGia>() select item;
            cbTacgia.ItemsSource = khanhHangTable;
            cbTacgia.DisplayMemberPath = "TenTacGia";
            cbTacgia.SelectedValuePath = "ID";
            var khanhHangTable1 = from item in db.GetTable<theLoai>() select item;
            cbTheloai.ItemsSource = khanhHangTable1;
            cbTheloai.DisplayMemberPath = "TheLoai";
            cbTheloai.SelectedValuePath = "ID";
           
        }


        private void btThem(object sender, RoutedEventArgs e)
        {
            ThemSach();
            GetData();
        }

        private void ThemSach()
        {
           
                if (tblId.Text == "" || tblTenSach.Text == "" || cbTacgia.Text == "" || cbTheloai.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                    return;
                }
            List<sach> data = db.saches.Where(t => t.MaSach == tblId.Text).ToList();
            
                if (data.Count > 0)
                {
                    MessageBox.Show("mã sách đã  tồn tại");
                    return;
                }
            else
            {
                sach sa = new sach();
                sa.MaSach = tblId.Text;
                sa.TenSach = tblTenSach.Text;
                sa.IDTacGia = int.Parse(cbTacgia.SelectedValue.ToString());
                sa.IDTheLoai = int.Parse(cbTheloai.SelectedValue.ToString());
                db.saches.InsertOnSubmit(sa);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
            }
               
        
        }
           
        private void btSua(object sender, RoutedEventArgs e)
        {
            SuaSach();
            GetData();
        }
        private void SuaSach()
        {
            if (tblId.Text == "" || tblTenSach.Text == "" || cbTacgia.Text == "" || cbTheloai.Text == "")
            {
                MessageBox.Show("Chọn một dòng cần sửa");
                return;
            }
            sach sa = db.saches.Single(item => item.MaSach == tblId.Text);
                sa.TenSach = tblTenSach.Text;
                sa.IDTacGia = int.Parse(cbTacgia.SelectedValue.ToString());
                sa.IDTheLoai = int.Parse(cbTheloai.SelectedValue.ToString());
                db.SubmitChanges();
            MessageBox.Show("Sửa  thành công");
        }

        private void btXoa(object sender, RoutedEventArgs e)
        {
            XoaSach();
            GetData();

        }
        private void XoaSach()
        {
            if (tblId.Text == "" || tblTenSach.Text == "" || cbTacgia.Text == "" || cbTheloai.Text == "")
            {
                MessageBox.Show("Chọn một  dòng  cần  xóa");
                return;
            }
            sach sa = db.saches.Single(item => item.MaSach == tblId.Text);

                db.saches.DeleteOnSubmit(sa);

                db.SubmitChanges();
            MessageBox.Show("Xóa thành  công");


        }

    }
}
