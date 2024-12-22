using Newtonsoft.Json;
class ListStudents{
      List<Student> listStudents = new List<Student>();

    public void ThemHocSinh(Student student) {
        listStudents.Add(student);
    } 
    public Student TimHocSinhTheoTen(string ten) {
        foreach (var student in listStudents)
    {
        if (student.TenHocSinh.Contains(ten, StringComparison.OrdinalIgnoreCase))
        {
            return student; 
        }
    }
    return null;
    }
       

    public void CapNhatDiem(string maHocSinh, double diemToan, double diemVan, double diemAnh)
    {
        foreach (var hs in listStudents)
        {
            if (hs.MaHocSinh == maHocSinh)
            {
                hs.DiemToan = diemToan;
                hs.DiemVan = diemVan;
                hs.DiemAnh = diemAnh;
                break;
            }
        }
    }

    public void XoaHocSinh(string maHocSinh) {
        for (int i = 0; i < listStudents.Count; i++)
        {
            if (listStudents[i].MaHocSinh == maHocSinh)
            {
                listStudents.RemoveAt(i);
                break;
            }
        }
    }

    public void HienThiDanhSach()
    {
        foreach (var hs in listStudents)
        {
            Console.WriteLine($"{hs.MaHocSinh} - {hs.TenHocSinh} - DTB: {hs.TinhDiemTrungBinh():F2} - Xep loai: {hs.XepLoai()}");
        }
    }

    public void SapXepTheoDiemTrungBinh()
    {
       for (int i = 0; i < listStudents.Count - 1; i++)
        {
            for (int j = i + 1; j < listStudents.Count; j++)
            {
                if (listStudents[i].TinhDiemTrungBinh() > listStudents[j].TinhDiemTrungBinh())
                {
                    var temp = listStudents[i];
                    listStudents[i] = listStudents[j];
                    listStudents[j] = temp;
                }
            }
        }

        foreach (var hs in listStudents)
        {
            Console.WriteLine($"{hs.MaHocSinh} - {hs.TenHocSinh} - DTB: {hs.TinhDiemTrungBinh():F2}");
        }
    }

    public void SapXepTheoTen()
    {
        for (int i = 0; i < listStudents.Count - 1; i++)
        {
            for (int j = i + 1; j < listStudents.Count; j++)
            {
                string ten1 = listStudents[i].TenHocSinh.Split(' ')[^1];
                string ten2 = listStudents[j].TenHocSinh.Split(' ')[^1];
                if (string.Compare(ten1, ten2, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    var temp = listStudents[i];
                    listStudents[i] = listStudents[j];
                    listStudents[j] = temp;
                }
            }
        }

        foreach (var hs in listStudents)
        {
            Console.WriteLine($"{hs.MaHocSinh} - {hs.TenHocSinh}");
        }
    }
    

    public void LuuDuLieu()
    {
        var json = JsonConvert.SerializeObject(listStudents);
        File.WriteAllText("ListStudents.json", json);
        Console.WriteLine("Add student success");
    }

    public void DocDuLieu()
    {
        if (File.Exists("ListStudents.json"))
        {
            var json = File.ReadAllText("ListStudents.json");
            listStudents = JsonConvert.DeserializeObject<List<Student>>(json);
            HienThiDanhSach();
        }
    }
}