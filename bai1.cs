using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtong
{
    class Ex1
    {
        int n;
        public void nhap()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        public int tinhtong()
        {
            int i, S = 0;

            for (i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    S += i - (i + 1);
            }
            return S;
        }

        public double tinhtongphanSo()
        {
            int j;
            double A = 0.0;

            for (j = 1; j <= n; j++)
            {
                A = A + 1 / (double)j;
            }
            return A;
        }
        public int tinhtong2()
        {
            int k, Sum = 0;
            for (k = n; k > 0; k--)
            {
                Sum += k;
            }
            return Sum;
        }
        public int tinhtonguoc()
        {
            int b, Tong = 0;
            for (b = 1; b < n; b++)
            {
                if (n % b == 0)
                    Tong += b;
            }
            return Tong;
        }

        public void In()
        {
            Console.WriteLine("Ket qua cua cau a la: {0} \n" +
                "Ket qua cua cau b la: {1} \n" +
                "Ket qua cua cau c la: {2} \n" +
                "Ket qua cua cau d: {3}",
                this.tinhtong(), this.tinhtongphanSo(), this.tinhtong2(), this.tinhtonguoc());
        }
    }
}
