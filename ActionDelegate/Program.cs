namespace ActionDelegate
{
    internal class Program
    {
        //CHALLENGE #1: VIẾT HÀM IN RA CÂU THÔNG BÁO: NAM EM ĐÃ RA VIỆN R!!!
        //              VIẾT THEO STYLE TRUYỀN THỐNG , NHỚ RUN HÀM
        //C#2: VIẾT HÀM IN RA CÂU THÔNG BÁO: NAM EM VÀ 35 TRIỆU!!!
        //     DÙNG DELEGATE VÀ ANONYMOUS FUNCTION
        //C#3: VIẾT HÀM IN RA CÂU THÔNG BÁO: 8/3/2024: CHÚNG TA CỦA TƯƠNG LAI DÙNG DELEGATE VÀ LAMBDA
        //C#3: DÙNG HÀM C#1 VÀ KẾT HỢP VỚI DELEGATE
        //C#5: KO DÙNG DELEGATE CỦA TA DO TA TẠO NÊN NoInputNoOutputDelegate() anymore
        //MS, .NET SDK CUNG CẤP SẴN CHO 1 TA 1 DELEGATE STYLE VOID F()
        //GỌI LÀ: Action, làm đi, hành động đi, run đi, vậy thôi, ko cần vào, ko cần ra
        //NẾU SAU NÀY BẠN LÀM VIỆC VỚI HÀM KO-VÀO-KO-RA THÌ TA KO CẦN GẠO DELEGATE
        // MÀ XÀI LUÔN Action và chỉ việc khai báo biến = trỏ đến hàm nào là xong

        //C#5: VIẾT HÀM IN RA CÂU THÔNG BÁO "8/3/2K4: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP VS HẢI TÚ VS THIỀU BẢO TRÂM"
        delegate void NoInNoOutputDelegate();

        static void Main(string[] args)
        {
            NoInNoOutputDelegate f1 = delegate () { };
            NoInNoOutputDelegate f2 = () => { };

            Console.WriteLine("C#5: XÀI ACTION");
            //Action f3 = () => {};
            Action f4 = ShowNotification; //truyền thống hàm có sẵn ngoài kia
            f4();// Nam Em đã ra viện
            Action f5 = () => 
            {
                Console.WriteLine("8/3/2K4: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP VS HẢI TÚ VS THIỀU BẢO TRÂM");
            };

            Action f6 = () => Console.WriteLine("\"8/3/2K4: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP VS HẢI TÚ VS THIỀU BẢO TRÂM");
            //Action che cho mình việc khai báo dài
            f6.Invoke();
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("CHALLENGE #1 - CALL METHOD AS NORMAL\n");
        //    ShowNotification();

        //    Console.WriteLine("CHALLENGE #2 - CALL METHOD USING ANONYMOUS FUNC\n");
        //    //NoInNoOutputDelegate f = delegate () { };
        //    NoInNoOutputDelegate f1 = delegate () {
        //        Console.WriteLine("2/3/2024 NAM EM VÀ 35.000.000 VND!!!\n");//VIP
        //    };
        //    //RUN HÀM
        //    f1();

        //    Console.WriteLine("CHALLENGE #3 - CALL METHOD USING LAMBDA\n");

        //    NoInNoOutputDelegate f2 = () =>
        //    { 
        //        Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LAI !!!\n");//VIP
        //    };

        //    NoInNoOutputDelegate f3 = () => Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LAI !!!\n");//VIP
        //    f3.Invoke();

        //    Console.WriteLine("CHALLENGE #4 - CALL METHOD USING DELEGATE & EXPLICIT METHOD \n");
        //    NoInNoOutputDelegate f4 = ShowNotification; //gán = hàm có sẵn
        //    //               luật sư   thân chủ
        //    f4.Invoke();
        //}

        static void ShowNotification() => Console.WriteLine("2/3/2024 NAM EM ĐÃ RA VIỆN!!!\n");
        //HÀM FULL TÊN MÀ XÀI "=>" ĐÍCH THỊ LÀ EXPRESSION BODY
    }
}