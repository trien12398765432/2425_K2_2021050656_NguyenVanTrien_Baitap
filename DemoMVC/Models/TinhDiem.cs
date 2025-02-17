using System;

class TinhDiem
{
    static void Main()
    {
        Console.Write("Nhập điểm thành phần A: ");
        double diemA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập điểm thành phần B: ");
        double diemB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập điểm thành phần C: ");
        double diemC = Convert.ToDouble(Console.ReadLine());

        double trongSoA = 0.6;
        double trongSoB = 0.3;
        double trongSoC = 0.1;
        
        double diemTongKet = (diemA * trongSoA) + (diemB * trongSoB) + (diemC * trongSoC);

        Console.WriteLine($"Điểm tổng kết: {diemTongKet:F2}");
    }
}



