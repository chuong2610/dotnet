
using Newtonsoft.Json;
class ProductManager
{
   
   public List<Product> Products  = new List<Product>();

    public void AddProduct()
    {
        Console.Write("Nhập mã sản phẩm: ");
        string id = Console.ReadLine();
        Console.Write("Nhập tên sản phẩm: ");
        string name = Console.ReadLine();
        Console.Write("Nhập giá bán: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số lượng tồn kho: ");
        int stock = Convert.ToInt16(Console.ReadLine());

        Products.Add(new Product(id,name,price,stock) );
        Console.WriteLine("Thêm sản phẩm thành công.");
    }

    public void SearchProductByName()
    {
        Console.Write("Nhập tên sản phẩm cần tìm: ");
        string name = Console.ReadLine();
        List<Product> result = new List<Product>();
        foreach (var product in Products)
        {
            if (product != null && !string.IsNullOrEmpty(product.TenSanPham) && product.TenSanPham.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                result.Add(product);
            }
        }

        if (result.Count > 0)
        {
            Console.WriteLine("Kết quả tìm kiếm:");
            foreach (var product in result)
            {
                Console.WriteLine($"Mã: {product.MaSanPham}, Tên: {product.TenSanPham}, Giá: {product.GiaBan}, Tồn kho: {product.SoLuongTonKho}");
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm.");
        }
    }

    public void UpdateProduct()
    {
        Console.Write("Nhập mã sản phẩm cần cập nhật: ");
        string id = Console.ReadLine();
        Product product = null;
        foreach (var p in Products)
        {
            if (p.MaSanPham == id)
            {
                product = p;
                break;
            }
        }

        if (product != null)
        {
            Console.Write("Nhập giá mới (nhập -1 để bỏ qua): ");
            double price = double.Parse(Console.ReadLine());
            if (price >= 0) product.GiaBan = price;

            Console.Write("Nhập số lượng tồn kho mới (nhập -1 để bỏ qua): ");
            int stock = int.Parse(Console.ReadLine());
            if (stock >= 0) product.SoLuongTonKho = stock;

            Console.WriteLine("Cập nhật sản phẩm thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm.");
        }
    }

    public void CalculateTotalStockValue()
    {
        double totalValue = 0;
        foreach (var product in Products)
        {
            totalValue += product.GiaBan * product.SoLuongTonKho;
        }
        Console.WriteLine($"Tổng giá trị kho hàng: {totalValue}");
    }

    public void DeleteProduct()
    {
        Console.Write("Nhập mã sản phẩm cần xóa: ");
        string id = Console.ReadLine();
        Product product = null;
        foreach (var p in Products)
        {
            if (p.MaSanPham == id)
            {
                product = p;
                break;
            }
        }

        if (product != null)
        {
            Products.Remove(product);
            Console.WriteLine("Xóa sản phẩm thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm.");
        }
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Danh sách sản phẩm:");
        foreach (var product in Products)
        {
            Console.WriteLine($"Mã: {product.MaSanPham}, Tên: {product.TenSanPham}, Giá: {product.GiaBan}, Tồn kho: {product.SoLuongTonKho}");
        }
    }
      public void DisplayProductsByPriceAscending()
    {
        for (int i = 0; i < Products.Count - 1; i++)
        {
            for (int j = i + 1; j < Products.Count; j++)
            {
                if (Products[i].GiaBan > Products[j].GiaBan)
                {
                    var temp = Products[i];
                    Products[i] = Products[j];
                    Products[j] = temp;
                }
            }
        }

        Console.WriteLine("Danh sách sản phẩm theo giá tăng dần:");
        foreach (var product in Products)
        {
            Console.WriteLine($"Mã: {product.MaSanPham}, Tên: {product.TenSanPham}, Giá: {product.GiaBan}, Tồn kho: {product.SoLuongTonKho}");
        }
    }

    public void DisplayProductsByNameAscending()
    {
        for (int i = 0; i < Products.Count - 1; i++)
        {
            for (int j = i + 1; j < Products.Count; j++)
            {
                if (string.Compare(Products[i].TenSanPham, Products[j].TenSanPham, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    var temp = Products[i];
                    Products[i] = Products[j];
                    Products[j] = temp;
                }
            }
        }

        Console.WriteLine("Danh sách sản phẩm theo tên tăng dần:");
        foreach (var product in Products)
        {
            Console.WriteLine($"Mã: {product.MaSanPham}, Tên: {product.TenSanPham}, Giá: {product.GiaBan}, Tồn kho: {product.SoLuongTonKho}");
        }
    }

    public void SaveData()
    {
        File.WriteAllText("products.json", JsonConvert.SerializeObject(Products));
        Console.WriteLine("Dữ liệu sản phẩm đã được lưu.");
    }

    public void LoadData()
    {
        if (File.Exists("products.json"))
        {
            Products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("products.json"));
        }
    }
}