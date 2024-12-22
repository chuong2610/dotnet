class Product
{
    
    private string maSanPham;
    public string MaSanPham
    {
        get { return maSanPham; }
        set { maSanPham = value; }
    }

    private string tenSanPham;
    public string TenSanPham
    {
        get { return tenSanPham; }
        set { tenSanPham = value; }
    }

    private double giaBan;
    public double GiaBan
    {
        get { return giaBan; }
        set { giaBan = value; }
    }

    private int soLuongTonKho;
    public int SoLuongTonKho
    {
        get { return soLuongTonKho; }
        set { soLuongTonKho = value; }
    }

    public Product(String maSanPham, string tenSanPham,double giaBan,int soLuongTonKho){
        this.maSanPham=maSanPham;
        this.tenSanPham=tenSanPham;
        this.giaBan=giaBan;
        this.soLuongTonKho=soLuongTonKho;
    }

}