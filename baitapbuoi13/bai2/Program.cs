internal class Program
{
    private static void Main(string[] args)
    {
       ProductManager productManager = new ProductManager();
      

        productManager.LoadData();
      

        int choice;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Tìm kiếm sản phẩm theo tên");
            Console.WriteLine("3. Cập nhật giá bán hoặc số lượng tồn kho");
            Console.WriteLine("4. Tính tổng giá trị kho hàng");
            Console.WriteLine("5. Xóa sản phẩm");
            Console.WriteLine("6. Hiển thị danh sách sản phẩm");
            Console.WriteLine("7. Hiển thị danh sách theo giá bán tăng dần");
            Console.WriteLine("8. Hiển thị danh sách theo tên");
            Console.WriteLine("9. Thoát");

            Console.Write("Chọn chức năng: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    productManager.AddProduct();
                    break;
                case 2:
                    productManager.SearchProductByName();
                    break;
                case 3:
                    productManager.UpdateProduct();
                    break;
                case 4:
                    productManager.CalculateTotalStockValue();
                    break;
                case 5:
                    productManager.DeleteProduct();
                    break;
                case 6:
                    productManager.DisplayProducts();
                    break;
                case 7:
                    productManager.DisplayProductsByPriceAscending();
                    break;
                case 8:
                    productManager.DisplayProductsByNameAscending();
                    break;    
                case 9:
                    productManager.SaveData();
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }

        } while (choice != 9);
    }
}