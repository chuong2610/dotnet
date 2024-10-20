// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// #region học phép toán cơ bản

// int a= 5+10;
// Console.WriteLine($"kết quả cộng 2 số 5 và 10 là:{a} ");

// int b= 5-10;
// Console.WriteLine($"kết quả trừ 2 số 5 và 10 là:{b} ");

// int c =5*10;
// Console.WriteLine($"kết quả nhân 2 số 5 và 10 là:{c} ");

// int d= 10/5;
// Console.WriteLine($"kết quả chia lấy nguyên 2 số 10 và 5 là:{d} ");
// int e= 10%5;
// Console.WriteLine($"kết quả chia lấy dư 2 số 10 và 5 là:{e} ");
// #endregion

// #region toán tử
// int cong =0;
// cong+=10;
// Console.WriteLine($"Numberic toán tử cộng: {cong}");
// #endregion

// #region tính BMI 
//Console.Write("Enter height(m): ");
// string h=Console.ReadLine();
// double height = Convert.ToDouble(h);
// Console.Write("Enter weight(kg): ");
// string w=Console.ReadLine();
// double weight = Convert.ToDouble(w);
// double bmi=0.0;
// bmi=weight/(height*height);
// Console.WriteLine($"BMI của bạn là: {bmi}");
// #endregion

Console.Write("nhập bán kính hình tròn:");
string a= Console.ReadLine();
double r = Convert.ToDouble(a);
double c= Math.PI*2*r;
double s=Math.PI*r*r;
Console.WriteLine($"Chu vi hình tròn: {c}");
Console.WriteLine($"Chu vi hình tròn: {s}");
