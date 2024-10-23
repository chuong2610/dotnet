Console.Write("Nhập giá trị của đơn hàng: ");
string? n=Console.ReadLine();
double a= Convert.ToDouble(n);
Console.Write("Nhập % giảm giá (%): ");
n=Console.ReadLine();
double b= Convert.ToDouble(n);
double c= b/100*a;
double d=a-b/100*a;
Console.WriteLine("số tiền được giảm giá là: "+c);
Console.Write("số tiền phải thanh toán là: "+d);


