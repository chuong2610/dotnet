class Student{
    private string maHocSinh;
    public string MaHocSinh { 
        get{return maHocSinh;}
        set{
            maHocSinh=value;
        }
     }

    private string tenHocSinh;
    public string TenHocSinh { 
        get {return tenHocSinh;}
        set{tenHocSinh=value; }    
     }
    private double diemToan;
    public double DiemToan { 
        get{return diemToan;}
        set{
            diemToan=value;
        }
     }

    private double diemVan;
    public double DiemVan { 
        get{return diemVan;}
        set{
            diemVan=value;
        }
     }

     private double diemAnh;
    public double DiemAnh { 
        get{return diemAnh;}
        set{
            diemAnh=value;
        }
     }

   

    public double TinhDiemTrungBinh() => (diemToan + diemVan + diemAnh) / 3;

    public string XepLoai()
    {
        double dtb = TinhDiemTrungBinh();
        if (dtb < 5) return "Yeu";
        if (dtb <= 6.5) return "Trung Binh";
        if (dtb <= 8) return "Kha";
        return "Gioi";
    }
}