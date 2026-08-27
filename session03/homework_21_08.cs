using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Authentication;
using System.Text;

namespace CSLT_UEH.session03
{
    enum CurrencyType
    {
        USD = 25400,
        EUR = 27200,
        JPY = 165,
        GBP = 32100
    }
    internal class homework_21_08
    {
        static void Bai_1()
        {
            Console.WriteLine("Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang (EVN)");

            Console.WriteLine("Nhập chỉ số điện cũ (kWh):");
            float csd_cu = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập chỉ số điện mới (kWh):");
            float csd_moi;
            while (true)
            {
                string? input = Console.ReadLine();
                if (!float.TryParse(input, out csd_moi))
                {
                    Console.WriteLine("Chỉ số điện mới không hợp lệ! vui lòng nhập lại");
                    continue;
                }
                if (csd_moi >= csd_cu)
                    break;
                else
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn chỉ số điện cũ! vui lòng nhập lại");
            }
            float tieuThu = csd_moi - csd_cu;
            float tienDien = 0;
            float VAT = 0;
            float tongTien = 0;
            //Bậc 1: Cho 50 kWh đầu tiên (từ 0 - 50 kWh): 1.806 VNĐ/kWh 
            if (tieuThu == 0)
                Console.WriteLine("Tổng tiền điện = 0 VNĐ");
            if (tieuThu > 0 && tieuThu <= 50)
            {
                tienDien = tieuThu * 1806;
            }
            //Bậc 2:Cho 50 kWh tiếp theo (từ 51 - 100 kWh): 1.866 VNĐ/kWh 
            else if (50 < tieuThu && tieuThu <= 100)
            {
                tienDien = 50 * 1806 + (tieuThu - 50) * 1866;
            }
            //Bậc 3: Cho 100 kWh tiếp theo(từ 101 - 200 kWh): 2.167 VNĐ / kWh
            else if (100 < tieuThu && tieuThu <= 200)
            {
                tienDien = 50 * 1806 + 50 * 1866 + (tieuThu - 100) * 2167;
            }
            //Bậc 4: Cho 100 kWh tiếp theo (từ 201 - 300 kWh): 2.729 VNĐ/kWh
            else if (tieuThu > 200 && tieuThu <= 300)
            {
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + (tieuThu - 200) * 2729;
            }
            //Bậc 5: Cho toàn bộ kWh từ 301 kWh trở lên: 3.050 VNĐ/kWh 
            else if (tieuThu > 300)
            {
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (tieuThu - 300) * 3050;
            }
            VAT = Convert.ToSingle(tienDien * 0.08);
            tongTien = Convert.ToSingle(tienDien + VAT);
            Console.WriteLine($"Tổng số điện tiêu thụ: {tieuThu} (kWh)");
            Console.WriteLine($"Tiền điện trước thuế: {tienDien:#,##0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {VAT:#,##0} VNĐ");
            Console.WriteLine($"Tổng tiền điện: {tongTien:#,##0} VNĐ");
        }
        static void Bai_2()
        {
            Console.WriteLine("Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe");
            Console.WriteLine("Nhập chiều cao (m):");
            double height;
            double weight;

            double bmi = 0;
            while (true)
            {
                string? input1 = Console.ReadLine();
                if (double.TryParse(input1, out height))
                    break;
                else
                {
                    Console.WriteLine("Chiều cao không hợp lệ! vui lòng nhập lại");
                }
            }
            Console.WriteLine("Nhập cân nặng (kg):");
            while (true)
            {
                string? input2 = Console.ReadLine();
                if (double.TryParse(input2, out weight))
                    break;
                else
                {
                    Console.WriteLine("Cân nặng không hợp lệ! vui lòng nhập lại");
                }
            }
            bmi = weight / Math.Pow(height, 2);
            if (bmi < 18.50)
                Console.WriteLine("Tình trạng sức khỏe: Gầy (Thiếu cân)");
            else if (bmi >= 18.5 && bmi < 23)
                Console.WriteLine("Tình trạng sức khỏe: Bình thường (Lý tưởng)");
            else if (bmi >= 23 && bmi < 25)
                Console.WriteLine("Tình trạng sức khỏe: Thừa cân (Tiền béo phì)");
            else if (bmi >= 25)
                Console.WriteLine("Tình trạng sức khỏe: Béo phì");
            double toiThieu = 18.5d * Math.Pow(height, 2);
            double toiDa = 25.9d * Math.Pow(height, 2);
            Console.WriteLine($"Chỉ số BMI: {bmi:#,##0.00}");
            Console.WriteLine($"Cân nặng lý tưởng: {toiThieu:#,##0.00} - {toiDa:#,##0.00} kg");
        }
        static void Bai_3()
        {
            Console.WriteLine("Bài 3: Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng");
            Console.WriteLine("Nhập số tiền muốn đổi (VNĐ):");
            decimal money = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Chọn loại tiền tệ muốn đổi sang (1-4) \t 1. USD \t    2. EUR\t  3. JPY\t   4. GBP:");
            int currency = int.Parse(Console.ReadLine());
            decimal rate;
            string donvi;
            switch (currency)
            {
                case 1:
                    rate = (decimal)CurrencyType.USD; donvi = "USD"; break;
                case 2:
                    rate = (decimal)CurrencyType.EUR; donvi = "EUR"; break;
                case 3:
                    rate = (decimal)CurrencyType.JPY; donvi = "JPY"; break;
                default:
                    rate = (decimal)CurrencyType.GBP; donvi = "GBP"; break;
            }
            decimal exchange = (decimal)(money / rate);
            decimal fees = 0.005m * money;
            Console.WriteLine($"Phí dịch vụ (0.5%): {fees:F2} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {Math.Round(money - fees, 2)} VNĐ");
            Console.WriteLine($"Số tiền nhận được: {Math.Round(exchange, 2)} {donvi}");
        }
        static void Bai_4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tính tuổi chính xác và đếm ngược ngày sinh nhật");
            Console.WriteLine("Nhập ngày tháng sinh (dd/mm/yyyy):");
            string str = Console.ReadLine();
            DateTime birthday = DateTime.ParseExact(str, "dd/MM/yyyy", null);
            DateTime now = DateTime.Now;
            TimeSpan tuoi = now - birthday;
            Console.WriteLine(tuoi);
            double day = tuoi.TotalDays;
            int age = (int)(day / 365);
            int ngay = (int)day;
            int nextbd = (age + 1) * 365 - ngay;
            Console.WriteLine($@"Tuổi hiện tại: {age} tuổi
            Bạn đã sống tổng cộng: {ngay} ngày
            Số ngày còn lại đến sinh nhật tiếp theo: {nextbd} ngày ");

        }
        static void Bai_5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string diemChu = "";
            double diemGPA = 0;
            string xepLoai = "";
            Console.WriteLine("Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA (4.0)");
            Console.WriteLine("Nhập điểm số môn Lập trình C# (thang 10):");
            double diem1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ:");
            int tinChi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm số môn Toán rời rạc (thang 10):");
            double diem2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ:");
            int tinChi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm số môn Tiếng Anh (thang 10):");
            double diem3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ:");
            int tinChi3 = int.Parse(Console.ReadLine());
            double Score_avg = (diem1 * tinChi1 + diem2 * tinChi2 + diem3 * tinChi3) / (tinChi1 + tinChi2 + tinChi3);
            if (Score_avg >= 8.5 && Score_avg <= 10)
            {
                diemChu = "A";
                diemGPA = 4.0;
                xepLoai = "Xuất sắc/Giỏi";
            }
            else if (Score_avg >= 7 && Score_avg <= 8.4)
            {
                diemChu= "B";
                diemGPA = 3.0;
                xepLoai = "Khá";
            }
            else if ( Score_avg >= 5.5 && Score_avg <= 6.9)
            {
                diemChu = "C";
                diemGPA = 2.0;
                xepLoai = "Trung bình";
            }
            else if (Score_avg >= 4.0 && Score_avg<= 5.4)
            {
                diemChu = "D";
                diemGPA = 1.0;
                xepLoai = "Yếu";
            }
            else
            {
                diemChu = "F";
                diemGPA = 0.0;
                xepLoai = "Kém (Trượt)";
            }

            Console.WriteLine($"Điểm trung bình thang 10: {Score_avg:F2}");
            Console.WriteLine($"Điểm chữ quy đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA thang 4: {diemGPA:F1}");
            Console.WriteLine($"Xếp loại học lực: {xepLoai}");

        }
        private static void Main1(string[] args)
        {
        }



    }

}
    

