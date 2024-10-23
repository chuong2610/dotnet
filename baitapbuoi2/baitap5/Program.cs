Console.Write("nhập USD: ");
String? n=Console.ReadLine();
double a=Convert.ToDouble(n);
Console.Write("Nhập tỷ giá : ");
n=Console.ReadLine();
double b=Convert.ToDouble(n);
Console.Write($"số tiền đã chuyển sang VND: {(a*b):F2}");
