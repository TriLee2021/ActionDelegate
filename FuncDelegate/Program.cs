namespace FuncDelegate
{
    //C#13: VIẾT HÀM NHẬN VÀO 1 CON SỐ SAU ĐÓ TRẢ VỀ BÌNH PHƯƠNG CỦA NÓ
    //CÓ RETURN, KO IN RA TRONG HÀM
    delegate double OneInputOneOutputDelegate(double value);
    //                  double F(double x)
    //MS LẠI BẢO RẰNG NẾU HÀM CÓ TRẢ VỀ GIÁ TRỊ int, long, char, Student, Car, Pet
    //và hàm có thể có đầu vào hay ko, KỆ, THÌ HÃY XÀI 1 DELEGATE STYLE GENERIC
    //TÊN LÀ FUNC
    //Func<int> -> hàm ko đầu vào và trả về int
    //Func<long> -> hàm ko đầu vào và trả về long
    //Func<string> -> hàm ko đầu vào và trả về string
    //Func<Dog> -> hàm ko đầu vào và trả về Dog
    //Func<int, int> -> hàm có đầu vào int và trả về int
    //Func<double, double, double> -> hàm có 2 đầu vào double và trả về double
    //BÊN PHẢI NHÁT LÀ ĐẦU RA, CÒN LẠI LÀ ĐẦU VÀO, CHƠI GENERIC CẢ ĐÁM
    //HÀM 5 ĐẦU VÀO, +1 ĐẦU RA -> 6 GENERIC
    //HÀM CÓ TỐI ĐA 16 ĐẦU VÀO T1 T2 T3 ... T16 CỘNG VỚI THẰNG ĐẦU A RESULT
    //HÀM CÓ KO ĐẦU VÀO => 17 LOẠI HÀM
    //
    //FUNC<int, int, long, char, Student, float, Pet, Lecture, ...int >
    //-------------------------------------------------------   ------
    //  đầu vào                                                 đầu ra
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#13: - METHODS RETURN VALUE");
            OneInputOneOutputDelegate f1 = ComputeExponent;
            f1(5);//25 ko có 25 mặc dù vẫn tính
            var result = f1(5);
            Console.WriteLine("5^2 = " + result);
            Console.WriteLine("10^2 = " + f1(10));

            //C#14: TÍNH BÌNH PHƯƠNG CỦA 1 CON SỐ R TRẢ VỀ KẾT QUẢ
            Func<int, double> f2 = x => x * x;

            Console.WriteLine("C#14 - METHOD RETURNS VALUE USING FUNC<>");
            Console.WriteLine("1000^2" + f2(1000)); //1 triệu

            //C#15:
            Func<double, double, double, double> f3 = (a, b, c) => a + b + c;
            Console.WriteLine("C#14 - TRIANGLE FUNC<>");
            Console.WriteLine($"3+4+5 = {f3(3, 4, 5)}"); //12
            //C#16: THÁCH THỨC DANH HÀI: VIẾT HÀM TRẢ VỀ 1 CON SỐ BẤT KỲ (NGẪU NHIÊN/ BẠN THÍCH) 6789 SBTC 2204 MMKC 
            Func<int> getMyOwnNumber = () => 6789; //JAVA MATH.RANDOM(...);

            //int r = getMyOwnNumber();

            Console.WriteLine("C#16 - RANDOM NUMBER<>");
            Console.WriteLine("My Own Number " + getMyOwnNumber());//12

            //C#17: VIẾT HÀM NHẬN VÀO 1 CON SỐ DOUBLE GPA ĐIỂM TRUNG BÌNH TRẢ VỀ TRUE NẾU GPA >=8, TRẢ VỀ FALSE NẾU GPA < 8
            Console.WriteLine("10 >= 8? " + CheckGrade(10));
            Console.WriteLine("10 >= 8? " + CheckGrade(5));
            Func<double, bool> CheckHang8 = gpa => gpa >= 8;

        }
        static bool CheckGrade(double gpa) => gpa >= 8;
                            //biểu thức so sánh luôn trả về true/false
                            //return nó luôn
        static double ComputeExponent(double n) => n * n;
    }
}