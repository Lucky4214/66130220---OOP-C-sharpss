using System.Runtime.CompilerServices;

namespace QLsinhvien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong hoc sinh:");
            List<SinhVien> listSV = new List<SinhVien>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n;i++)
            {
                Console.Write("Nhap ten:");
                string Ten = Console.ReadLine();
                Console.Write("Nhap diem:");
                double Diem = double.Parse(Console.ReadLine());
                SinhVien sv = new SinhVien();
                sv.name = Ten;
                sv.grade = Diem;
                listSV.Add(sv);
            }
            Console.WriteLine("Thong tin cua sinh vien la");
            foreach (SinhVien sv in listSV)
            {
                Console.WriteLine(sv);
            }
            //thêm sinh viên
            Console.Write("Nhap so luong sinh vien them:");
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                Console.Write("Nhap ten:");
                string Ten = Console.ReadLine();
                Console.Write("Nhap diem:");
                double Diem = double.Parse(Console.ReadLine());
                SinhVien svT = new SinhVien();
                svT.name = Ten;
                svT.grade = Diem;
                listSV.Add(svT);
            }
            Console.WriteLine("Danh sach sinh vien sau khi them la");
            foreach (SinhVien svT in listSV)
            {
                Console.WriteLine(svT);
            }
            // xóa sinh viên
            Console.Write("Nhap ten sinh vien muon xoa:");
            string xoaten = Console.ReadLine();
            listSV.RemoveAll(sv => sv.name == xoaten);
            Console.WriteLine("Danh sach sau khi xoa la:");
            foreach(SinhVien sv in listSV)
            {
                Console.WriteLine(sv);
            }
            // sửa tên và sửa điểm
            Console.Write("Nhap so thu tu index muon sua:");
            int vitri =int.Parse(Console.ReadLine());
            if(vitri > 0 && vitri <= listSV.Count)
            {
                Console.Write("Nhap ten moi:");
                string tenMoi = Console.ReadLine();
                Console.Write("Nhap diem moi:");
                double diemMoi = double.Parse(Console.ReadLine());
                listSV[vitri - 1].name = tenMoi;
                listSV[vitri - 1].grade = diemMoi;
            }
            else
            {
                Console.WriteLine("ko ton tai vi tri!");
            }
            Console.WriteLine("Danh sach sau khi sua la:");
            foreach (SinhVien sv in listSV)
            {
                Console.WriteLine(sv);
            }
            // tim kiem sinh vien
            Console.WriteLine("Nhap ten sinh vien muon tim");
            string timSV = Console.ReadLine();
            foreach (SinhVien sv in listSV)
            {
                if(sv.name == timSV)
                {
                    Console.WriteLine(sv);
                }
            }
        }
    }
    class SinhVien
    {
        private string NameStudent;
        private double GradeStudent;
        //getter setter
        public string name
        {
            get { return NameStudent; }
            set { NameStudent = value; }
        }
        public double grade
        {
            get { return GradeStudent; }
            set
            {
                if(value > 0)
                {
                    GradeStudent = value;
                }
                else
                {
                    GradeStudent = 0;
                }
            }
        }
        //constructor
        public SinhVien()
        {

        }
        public SinhVien(string Name,double Grade)
        {
            NameStudent = Name;
            GradeStudent= Grade;
        }
        //tostring
        public override string ToString()
        {
            return $"Ten:{name}\nDiem:{grade}";
        }
    }
}
