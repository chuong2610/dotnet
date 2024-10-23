Console.Write("Nhập số tiền gốc: ");
string? n=Console.ReadLine();
double a= Convert.ToDouble(n);
Console.Write("Nhập VAT (%): ");
n=Console.ReadLine();
double b= Convert.ToDouble(n);
double c= b/100*a;
double d=a+b/100*a;
Console.Write("tổng tiền sau khi cộng VAT là: "+d);


