using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timgiatrimang
{
    internal class TimGiaTriMang
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            string ten;
            Console.WriteLine("Nhập tên sinh viên cần tìm :");
            ten = Console.ReadLine();
            bool tim = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (ten == students[i])
                {
                    Console.WriteLine($"Vị trí {i+1}");
                    tim = true;
                    break;
                }
            }
            if (!tim)
            {
                Console.WriteLine("Không có " + ten + " trong danh sách.");
            }

            Console.ReadLine();
        }
    }
}
