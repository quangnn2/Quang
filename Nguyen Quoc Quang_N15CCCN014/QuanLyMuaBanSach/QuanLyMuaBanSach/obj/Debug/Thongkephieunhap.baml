   M S B A M L   `   `   `  ����K  GQuanLyMuaBanSach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:QuanLyMuaBanSachQuanLyMuaBanSach  5   	   '    !QuanLyMuaBanSach.Thongkephieunhap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:QuanLyMuaBanSach     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$   Thống kê phiếu nhập��5	   	   $	��300��6%   $	��520��62   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      #  MaterialDesignThemes.Wpf.Card  $��5q�6"   $��Stretch=�6-   .��5      �� -   5        $��Xuất báo cáo��5      $��5q�60   $	��120��6;   $
��Left=�6G   6y   5      5      � 5   
   $��1��6   .+�5      �� $
��Auto=�6   .��5      &   System.Windows.Controls.DataGrid  -   5        $��ListViewThongke��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6.   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ID+  5      $ 
Tên sách��6.    6A   �� *MaSach+  5      $  Nhà cung cấp��6-    6D   �� *IDNhaCungCap+  5      $ Số lượng��6-    6@   �� *	SoLuong+  5      $
 Giá��6-    6:   �� *Gia+  5      $ Ngày nhập ��6-    6B   �� *
NgayNhap+ �� StringFormat$ 
dd/MM/yyyy��5       5"      5#      5%      5&      