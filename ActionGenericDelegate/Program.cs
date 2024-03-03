namespace ActionGenericDelegate
{
    internal class Program
    {
        //C#6: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
        //VIẾT HÀM LẺ CÓ SẴN NGOÀI KIA 
        //ANONYMOUS FUNC, LAMBDA EXPRESSION => XÀI DELEGATE ÒI
        //C#7: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
        //DÙNG ANONYMOUS
        public delegate void OneInputNoOutputDelegate(int n);
        //void F(int x)
        //MS BẢO RẰNG: HÀM MÀ KO TRẢ RA GÌ CẢ, GỌI LÀ HÀM HÀNH ĐỘNG, ACTION 
        //TUY NHIÊN CÓ LOẠI HÀNH ĐỘNG, HÀM CẦN ĐẦU VÀO, 1 ĐẦU, 2 ĐẦU, 3 ĐẦU VÀO....
        //N ĐẦU VÀO -> CŨNG LÀ HÀNH ĐỘNG, CŨNG LÀ ACTION
        //TUY THẾ 1 ĐẦU VÀO CÓ THỂ INT, LONG, STUDENT, FLOAT
        //        2 ĐẦU VÀO CÓ THỂ LÀ INT|INT, INT|LONG, STRING|STRING, STRING|INT,...

        //HÀM NHIỀU THAM SỐ | THAM SỐ KHÁC NHAU VỀ DATA TYPE, THỨ TỰ DATATYPE!!!
        //VÔ CHỪNG LOẠI HÀM NHƯ THẾ NÀY???
        //GENERIC XUẤT HIỆN, DÙ BẠN INT, LONG, CHAR, PERSON, STUDENT, ABNT LÀ DATATYPE <T> MÀ THÔI, LÚC NÀO CẦN DÙNG, THAY <T> BẰNG DATATYPE CỤ THỂ

        //KỂ TỪ NAY VỀ SAU, MỖI KHI NÓI VỀ HÀM VOID, KO ĐẦU VÀO, THÌ XÀI 
        //Action f = ...
        //KỂ TỪ NAY VỀ SAU, MỖI KHI NÓI VỀ HÀM VOID, CÓ ĐẦU VÀO, 1, 2, 3, 4, .... 16 ĐẦU VÀO
        //THÌ XÀI, KHAI BÁO, DÙNG DELEGATE CÓ SAN84M STYLE GENERIC NHƯ SAU
        // Action<int>             f = hàm có 1 đầu vào int
        // Action<char>             f = hàm có 1 đầu vào char
        // Action<Student>             f = hàm có 1 đầu vào Student
        // Action<int, int>             f = hàm có 2 đầu vào int
        // Action<Student, int>             f = hàm có 2 đầu vào Student, int
        // Action<16 đầu vào>             f = hàm có 16 đầu vào
        static void Main(string[] args)
        {
            OneInputNoOutputDelegate f1 = ComputeExponent;//truyền thống, delegate tự trồng, tự build
            Action<int> f2 = ComputeExponent;
            Console.WriteLine("C#9: USING ACTION<> GENERIC ON THE METHOD WITH UP TO 16 PARAMS");
            f2(1000000); //1 triệu

            //C#10: DÙNG ACTION<> TÍNH MŨ 3 CỦA 1 CON SỐ VÀ IN RA. DÙNG LUÔN ANONYMOUS VÀ LAMBDA EXPRESSION
            Action<int> f3 = delegate (int x) { };
            Action<int> f4 = delegate (int x) { Console.WriteLine($"{x}^2 = {Math.Pow(x, 2)}"); };

            Console.WriteLine("C#10: USING ACTION<> GENERIC ON THE METHOD WITH UP TO 16 PARAMS - ^3");
            f4(3);//27

            Action<int> f5 = (int xxx) => { Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}"); };
            f5(30);//27

            //C#11: VIẾT HÀM IN RA DIỆN TÍCH HÌNH CHỮ NHẬT - WIDTH, LENGTH
            Action<double, double> f6 = (x, y) => Console.WriteLine($"{x}*{y} = {x * y}");

            Console.WriteLine("C#11: USING ACTION<> GENERIC ON THE METHOD WITH UP TO 16 PARAMS - AREA OF RECTANGLE");
            f6(20, 10);//200

            //C#12: IN RA CÁC SỐ CHẴN TỪ 1 ĐẾN N...
            Action<int> f11 = n =>
            {
                if (n < 1)
                {
                    Console.WriteLine("n must be > 0");
                    return;
                }
                Console.WriteLine($"The list of even numbers from 1...{n}");
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " ");
                    }    
                }
                Console.WriteLine();//sống có trách nhiệm, in hàng ngang xong phải xuống hàng
            };
            f11(100);
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("\nC#6: CALL METHOD AS NORMAL");
            //    ComputeExponent(5);//5^2 = 25

            //    Console.WriteLine("\nC#6: CALL METHOD USING ANONYMOUS FUNCTION");
            //    OneInputNoOutputDelegate f1 = ComputeExponent; //đc quyền hàm cùng style, BẰNG TÊN HÀM NÀO ĐÓ NGOÀI KIA, HÀM CÓ 2 TÊN, THÊM NICK

            //    OneInputNoOutputDelegate f2 = delegate (int xxx) 
            //    {
            //        Console.WriteLine($"{xxx}^2 = {xxx*xxx}");
            //        Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}");
            //    };

            //    f2(10); //100
            //    f2(50); //2500

            //    OneInputNoOutputDelegate f3 = (int xxx) => { };
            //    OneInputNoOutputDelegate f4 = (xxx) => { };
            //    OneInputNoOutputDelegate f5 = xxx => 
            //    {
            //        Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}");
            //    }; 
            //    OneInputNoOutputDelegate f7 = xxx => Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}");
            //    //LAMBDA EXPRESSION, CHỨ KO PHẢI EXPRESSION BODY; DO KO CÓ TÊN HÀM FULL
            //    f7(100);
            //}

            static void ComputeExponent(int x) => Console.WriteLine($"{x}^2 = {Math.Pow(x, 2)}");
            static void ComputeRectangle(int a, int b) => Console.WriteLine($"{a}*{b} = {a * b}");

            static void PrintNumbers(int n)
            {
                if (n < 1)
                {
                    Console.WriteLine("n must be > 0");
                    return;
                }
                Console.WriteLine($"The list of even numbers from 1...{n}");
                for (int i = 0; i <= n; i++)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                    Console.WriteLine();//sống có trách nhiệm, in hàng ngang xong phải xuống hàng
                }
            }
        }
    }
}