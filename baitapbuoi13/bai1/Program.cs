internal class Program
{
    private static void Main(string[] args)
    {
         ListStudents listStudents = new ListStudents();
        listStudents.DocDuLieu();

        while (true)
        {
            Console.WriteLine("\nQuan ly hoc sinh:");
            Console.WriteLine("1. Them hoc sinh");
            Console.WriteLine("2. Tim hoc sinh theo ten");
            Console.WriteLine("3. Cap nhat diem hoc sinh");
            Console.WriteLine("4. Xoa hoc sinh");
            Console.WriteLine("5. Hien thi danh sach hoc sinh");
            Console.WriteLine("6. Sap xep theo diem trung binh");
            Console.WriteLine("7. Sap xep theo ten");
            Console.WriteLine("8. Thoat");
            Console.Write("Chon chuc nang: ");

            int chon = Convert.ToInt16(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Console.Write("Nhap ma hoc sinh: ");
                    string ma = Console.ReadLine();
                    Console.Write("Nhap ten hoc sinh: ");
                    string ten = Console.ReadLine();
                    Console.Write("Nhap diem Toan: ");
                    double toan = double.Parse(Console.ReadLine());
                    Console.Write("Nhap diem Van: ");
                    double van = double.Parse(Console.ReadLine());
                    Console.Write("Nhap diem Anh: ");
                    double anh = double.Parse(Console.ReadLine());

                    listStudents.ThemHocSinh(new Student { MaHocSinh = ma, TenHocSinh = ten, DiemToan = toan, DiemVan = van, DiemAnh = anh });
                    break;

                case 2:
                    Console.Write("Nhap ten hoc sinh can tim: ");
                    string tenTim = Console.ReadLine();
                    var hsTim = listStudents.TimHocSinhTheoTen(tenTim);
                    if (hsTim != null)
                    {
                        Console.WriteLine($"Tim thay: {hsTim.MaHocSinh} - {hsTim.TenHocSinh}");
                    }
                    else
                    {
                        Console.WriteLine("Khong tim thay hoc sinh!");
                    }
                    break;

                case 3:
                    Console.Write("Nhap ma hoc sinh can cap nhat: ");
                    string maCapNhat = Console.ReadLine();
                    Console.Write("Nhap diem Toan moi: ");
                    double toanMoi = double.Parse(Console.ReadLine());
                    Console.Write("Nhap diem Van moi: ");
                    double vanMoi = double.Parse(Console.ReadLine());
                    Console.Write("Nhap diem Anh moi: ");
                    double anhMoi = double.Parse(Console.ReadLine());

                    listStudents.CapNhatDiem(maCapNhat, toanMoi, vanMoi, anhMoi);
                    break;

                case 4:
                    Console.Write("Nhap ma hoc sinh can xoa: ");
                    string maXoa = Console.ReadLine();
                    listStudents.XoaHocSinh(maXoa);
                    break;

                case 5:
                    listStudents.HienThiDanhSach();
                    break;

                case 6:
                    listStudents.SapXepTheoDiemTrungBinh();
                    break;

                case 7:
                    listStudents.SapXepTheoTen();
                    break;

                case 8:
                    listStudents.LuuDuLieu();
                    return;

                default:
                    Console.WriteLine("Chuc nang khong hop le!");
                    break;
            }
        }
    }
}