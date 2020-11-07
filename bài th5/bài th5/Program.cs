using System;

namespace bài_th5
{
    class TienDien
    {
        private string tenchuho, diachi;
        private int sodienthangtruoc, sodienthangnay;
        public TienDien()
        {
            tenchuho = " ";
            diachi = " ";
            sodienthangtruoc = 0;
            sodienthangnay = 10;
        }
        public TienDien(string tenchuho, string diachi, int sodienthangtruoc, int sodienthangnay)
        {
            this.tenchuho = tenchuho;
            this.diachi = diachi;
            this.sodienthangtruoc = sodienthangtruoc;
            this.sodienthangnay = sodienthangnay;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten chu ho:"); tenchuho = Console.ReadLine();
            Console.Write("Nhap dia chi:  "); diachi = Console.ReadLine();
            Console.Write("Nhap so dien thang truoc:"); sodienthangtruoc = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dien thang nay:"); sodienthangnay = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("{0}\t{1}\t{2}", tenchuho, diachi, sodiendadung);
        }
        public int sodiendadung
        {
            get
            {
                return sodienthangnay - sodienthangtruoc;
            }
        }
        public int Tinhtiendien()
        {
            return sodiendadung * 500;
        }

    }
    class Tiendienmoi : TienDien
    {
        private int dinhmuc;
        public Tiendienmoi() : base()
        {
            dinhmuc = 50;
        }
        public Tiendienmoi(string tenchuho, string diachi, int sodienthangtruoc, int sodienthangnay, int dinhmuc) : base(tenchuho, diachi, sodienthangtruoc, sodienthangnay)
        {
            this.dinhmuc = dinhmuc;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so dinh muc: "); dinhmuc = int.Parse(Console.ReadLine());

        }
        public new int Tinhtiendien()
        {
            if (sodiendadung < dinhmuc) return sodiendadung * 500;
            else return sodiendadung * 600;
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            Tiendienmoi t = new Tiendienmoi();
            t.Nhap();
            t.Hien();
            Console.WriteLine("Tiendien={0}", t.Tinhtiendien());
            Console.ReadKey();
        }
    }
    //bài 2
    class Tamgiac
    {
        private double a, b, c;
        public Tamgiac()
        {
            a = b = c = 0;
        }
        public Tamgiac(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Nhap()
        {
            Console.Write("Nhap canh a="); a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh b="); b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh c="); c = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("Ba canh lan luot la a={0}\tb={1}\tc={2}\tDientich={3}", a, b, c, Tinhdt());
        }
        public bool Ktr()
        {
            return a + b > c && b + c > a && a + c > b;
        }
        public double Tinhdt()
        {
            return Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));

        }
    }
    class Tudien : Tamgiac
    {
        private double h;
        public Tudien() : base()
        {
            h = 0;
        }
        public Tudien(double a, double b, double c, double h) : base(a, b, c)
        {
            this.h = h;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap chieu cao h="); h = int.Parse(Console.ReadLine());
        }
        public new void Hien()
        {
            base.Hien();
            Console.WriteLine("Chieu cao={0}\t The tich={1}", h, Tinhtt());
        }
        public double Tinhtt()
        {
            return Tinhdt() * 1 / 3 * h;
        }
    }
    class App2
    {
        static void Main3()
        {
            Tudien t = new Tudien();
            t.Nhap();
            t.Hien();
            Console.ReadKey();
        }
    }
    //bài 3
    class Matran
    {
        protected int m, n;
        protected int[,] a;
        public Matran()
        {
            m = n = 0;
            a = new int[m, n];
        }
        public Matran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
        }
        public void Nhap()
        {
            Console.Write("Nhap n="); n = int.Parse(Console.ReadLine());
            Console.Write("Nhap m="); m = int.Parse(Console.ReadLine());
            a = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }

    }
    class Matranvuong : Matran
    {

        public new void Nhap()
        {
            do
            {
                base.Nhap();
            } while (n != m);

        }
        public int TongDCC()
        {
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        t += a[i, j];

                }
            }
            return t;
        }
        public int TongDCP()
        {
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                        t += a[i, j];

                }
            }
            return t;
        }
        public int TongDCCk(int k)
        {
            int t = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == j)
                        t += a[i, j];

                }
            }
            return t;
        }
        public int TongDCPK(int k)
        {
            int t = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                        t += a[i, j];

                }
            }
            return t;
        }
    }
    class App3
    {
        static void Main4()
        {
            Matranvuong t = new Matranvuong();
            t.Nhap();
            Console.WriteLine("Tong duong cheo chinh:{0}", t.TongDCC());
            Console.WriteLine("Tong duong cheo phu:{0}", t.TongDCP());
            Console.WriteLine("Tong duong cheo chinh thu k:{0}", t.TongDCCk(2));
            Console.WriteLine("Tong duong cheo phu thu k:{0}", t.TongDCPK(2));
            Console.ReadKey();
        }
    }
    //bài 4
    class PTBH
    {
        protected double a, b, c;
        public PTBH()
        {
            a = b = c = 0;
        }
        public PTBH(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public void Nhap()
        {
            Console.Write("Nhap a="); a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b="); b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c="); c = double.Parse(Console.ReadLine());

        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value != 0) a = value;
            }
        }
        public double Delta()
        {
            return (b * b - 4 * A * c);
        }
        public void Giai()
        {

            if (Delta() > 0)
            {
                double x1 = (-b - Math.Sqrt(Delta())) / (2 * A);
                double x2 = (-b + Math.Sqrt(Delta())) / (2 * A);
                Console.WriteLine("Phuong trinh co hai nghiem \nx1={0}\nx2={1}", x1, x2);
            }
            else if (Delta() == 0) Console.WriteLine("Phuong trinh co nghiem duy nhat x={0}", -b / (2 * A));
            else Console.WriteLine("Phuong trinh vo nghiem");
        }


    }
    class PTTP : PTBH
    {
        public new void Giai()
        {
            double d = Delta();
            if (d == 0)
            {
                double y = -b / (2 * A);
                if (y < 0) Console.WriteLine("Phuong trinh vo nghiem!");
                else
                    Console.WriteLine("Phuong trinh trung phuong co 2 nghiem x1={0}\tx2={1}", -Math.Sqrt(y), Math.Sqrt(y));
            }
            else if (d < 0) Console.WriteLine("Phuong trinh vo nghiem");
            else
            {
                double y1 = (-b - Math.Sqrt(Delta())) / (2 * A);
                double y2 = (-b + Math.Sqrt(Delta())) / (2 * A);
                if (y1 < 0 && y2 < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (y1 > 0 && y2 < 0)
                    Console.WriteLine("Phuong trinh co 2 nghiem x1={0}\t x2={1}", Math.Sqrt(y1), -Math.Sqrt(y1));
                else if (y1 < 0 && y2 > 0)
                    Console.WriteLine("Phuong trinh co 2 nghiem x1={0}\t x2={1}", Math.Sqrt(y2), -Math.Sqrt(y2));
                else Console.WriteLine("Phuong trinh co 4 nghiem phan biet\n x1={0}\nx2={1}\nx3={2}\nx4={3}", Math.Sqrt(y1), -Math.Sqrt(y1), Math.Sqrt(y2), -Math.Sqrt(y2));
            }
        }
    }
    class App
    {
        static void Main()
        {
            PTTP p = new PTTP();
            p.Nhap();
            p.Giai();
            Console.ReadKey();
        }
    }
    //bài 5
    class Person
    {
        private string name, nationality;
        private int age;
        public Person()
        {
            name = nationality = " ";
            age = 0;
        }
        public Person(string name, string nationality, int age)
        {
            this.name = name;
            this.nationality = nationality;
            this.age = age;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten:"); name = Console.ReadLine();
            Console.Write("Nhap tuoi: "); age = int.Parse(Console.ReadLine());
            Console.Write("Nhap quoc tich:"); nationality = Console.ReadLine();
        }
        public void Hien()
        {
            Console.WriteLine("Ten:{0}\tTuoi:{1}\tQuoc tich:{2}", name, age, nationality);
        }

    }
    class Player : Person
    {
        private int number;
        private string position;
        private Team team;
        public Player() : base()
        {
            number = 0;
            position = " ";
        }

        public Player(string name, string nationality, int age, int number, string position, Team team) : base(name, nationality, age)
        {
            this.number = number;
            this.position = position;
            this.team = team;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so ao:"); number = int.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri thi dau:"); position = Console.ReadLine();

        }
        public new void Hien()
        {
            base.Hien();
            Console.WriteLine("{0}\t{1}\t{2}", number, position, team);
        }


    }
    class Coach : Person
    {
        private int year;
        public Coach() : base()
        {
            year = 0;
        }
        public Coach(string name, string nationality, int age, int year) : base(name, nationality, age)
        {
            this.year = year;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so nam lam huan luyen vien:"); year = int.Parse(Console.ReadLine());
        }
        public new void Hien()
        {
            base.Hien();
            Console.Write("{0}", year);
        }
    }
    class Team

    {
        private string name;
        private Player[] ds;
        private Coach coach;

        public void Nhap()
        {
            Console.Write("Nhap ten doi: "); name = Console.ReadLine();
            ds = new Player[11];

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Nhap cau thu thu {0}", i + 1);
                ds[i] = new Player();
                ds[i].Nhap();

            }
        }
        public void Hien()
        {
            Console.WriteLine("{0}", name);
            for (int i = 0; i < 11; i++)
                ds[i].Hien();
        }
    }
    class App1
    {
        static void Main2()
        {
            Team t = new Team();
            t.Nhap();
            t.Hien();
            Console.ReadKey();
        }
    }
}
