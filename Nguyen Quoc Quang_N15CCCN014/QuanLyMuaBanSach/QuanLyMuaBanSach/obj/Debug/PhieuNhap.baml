   M S B A M L   `   `   `  ����K  GQuanLyMuaBanSach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:QuanLyMuaBanSachQuanLyMuaBanSach  5   	        QuanLyMuaBanSach.PhieuNhap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:QuanLyMuaBanSach     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Phiếu Nhập��5	      $	��400��6   $	��570��6'   ���#A4A4A4.��5
      � $	��300��6   $	��Top=�6    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��1��6   $��5 q�6+   .��5      � .+�5      �� -   5        $��tblId��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID��6'   $��5 5 15 5q�6K   $��14(�6]    %  !MaterialDesignFloatingHintTextBox#��[  6k   �� 5      -   5         ��Name$ 	cbTenSach��5      $ 
Tên sách��6.   $��5 5 15 5q�6X   $��14(�6j    & "MaterialDesignFloatingHintComboBox#��[ 6x   6�   �� 5      -   5        $ cbNahCungCap��5      $ Nhà cung cấp��61   $��5 5 15 5q�6_   $��14(�6q   #��[ 6   6�   �� 5      -   5        $��
tblSoLuong��5      $ Số lượng��6,   $��5 5 15 5q�6V   $��14(�6h   #��[  6v   �� 5      -   5        $��tblGia��5      $ Giá nhập��6(   $��5 5 15 5q�6R   $��14(�6d   #��[  6r   (  "System.Windows.Controls.DatePicker  5      -   5        $��pdNgay��5      $	��100��6+   $��5 5 15 5q�67   $��14(�6I   $��Bottom=�6W   $ Ngày nhập��6r    ( $MaterialDesignFloatingHintDatePicker#��[ 6�   5      5        5   
   $��0��6   $��5 q�6+   .��5      � .+�5      �� -   5        $��Thêm��5      $��5q�6(   $	��100��63   ���#0080FF6e   �� 5      -   5        $
��Xóa��5      $��5q�6'   $	��100��62   ���#0080FF6c   �� 5      -	   5        $��Sửa��5      $��5q�6'   $	��100��62   ���#0080FF6c   �� 5      -
   5        $��Thống kê��5      $��5q�6,   $	��100��67   $
��Left=�6C   6v   5       5!        5"   
   $��2��6   $��5 q�6+   $��Stretch=�68   .��5#      �� $
��Auto=�6   .��5$      &   System.Windows.Controls.DataGrid  -   5        $��datagrid��5$   I   $��10q�6Y      CanUserAddRows .     CanUserReorderColumns .     CanUserResizeRows .     
IsReadOnly .    CanUserResizeColumns . 	   CanUserSortColumns	 .  
   AutoGenerateColumns
 .     Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6.   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ID+  5'      $ 
 Mã sách��6.    6A   �� *MaSach+  5(      $ ID Nhà cung cấp��6-    6F   �� *IDNhaCungCap+  5)      $ Số lượng��6-    6@   �� *	SoLuong+  5*      $
 Giá��6-    6:   �� *Gia+  5+      $ Ngày nhập ��6-    6B   �� *
NgayNhap+ �� StringFormat$ 
dd/MM/yyyy��5-      5/      50      54      55      