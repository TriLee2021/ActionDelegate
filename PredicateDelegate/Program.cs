namespace PredicateDelegate
{
    //MS BẢO RẰNG NẾU HÀM NHẬN VÀO ĐÚNG 1 ĐẦU VÀO VÀ HÀM TRẢ VỀ BOOLEAN 
    //MỞ RỘNG THÊM: TOÁN LOGIC, TOÁN MỆNH ĐỀ - CÂU PHẤT BIỂU DING91 SAI 
    //CÓ MỆNH ĐỀ - HÀM NHẬN 1 ĐẦU VÀO SAU ĐÓ TRẢ VỀ 1 CÂU PHÁT BIỂU ĐÚNG SAI HÀM NÀY GỌI LÀ HÀM TIÊN ĐOÁN, HÀM DỰ ĐOÁN, ĐÁNH GIÁ, LƯỢNG GIÁ,... PREDICATE - LOGIC VỊ TỰ
    //ÔNG X LÀ 1 NHÀ TOÁN HỌC -> CÂU NÀY KO BIẾT ĐÚNG SAI VÌ X LÀ BIẾN
    //HÀM IsNhaToan(ông/bà X nào đó)
    //Hàm nhận vào con người, trả ra đúng sai nếu đó là nhà toán học hay không
    //IsNhaToanHoc(Ngô Bảo Châu) => Ông Ngô Bảo Châu là 1 nhà toán học => nệnh đề ĐÚNG
    //IsNhaToanHoc(giao.lang) => SAI R, GÃ LÀM THUÊ CHO TƯ BẢN ĐAM MÊ CODE, KO ĐAM MÊ TIỀN 7H SÁNG ĐẾN 7H TỐI!!!
    //PREDICATE (???) => TRUE/FALSE
    //HÃY ĐOÁN XEM ?? LÀ ĐÚNG HAY SAI 

    //MS BẢO RẰNG NẾU HÀM NHẬN VÀO ĐÚNG 1 ĐẦU VÀO VÀ HÀM TRẢ VỀ BOOLEAN 
    //THAY VÌ KHAI BÁO LÀ Func<double, bool> THÌ KHAI BÁO LÀ Predicate<double> là đủ
    //THAY VÌ KHAI BÁO LÀ Func<Student, bool> THÌ KHAI BÁO LÀ Predicate<Student> là đủ -> kiểm tra xem Student x có đúng là ???

    internal class Program
    {
        static void Main(string[] args)
        {
            //Hàm cuối cùng #18 viết hàm nhận vào 1 số gpa, trả về nó lớn hơn hay bằng 8 hay không
            Func<double, bool> check8V1 = gpa => gpa >= 8;
            Predicate<double> check8V1_ = gpa => gpa >= 8;
            //hàm nhận vào con gpa trả ra có đúng là lớn hơn 8 hay không
            Console.WriteLine("Final: 10 > 8 hay ko? " + check8V1(10));
            //LỆNH CUỐI CÙNG
            //CÂU VIEW
            var x = 2004.715; //7h15
            var fx = (double a, double b, double c) => a + b + c;
            Func<double, double, double, double> fxx = (a, b, c) => a + b + c;
            //HÀM TÍNH CHU VI TAM GIÁC TỔNG 3 SỐ
        }
    }
}