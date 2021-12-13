using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_study_p333
{
    class BirthdayInfo
    {
        public string Name
        {
            get;
            set;
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }

        class MainApp
        {
            static void Main(string[] args)
            {
                BirthdayInfo birth = new BirthdayInfo()
                {
                    Name = "서현",
                    Birthday = new DateTime(1991, 6, 28) // 프로퍼티를 이용한 초기화 
                };

                Console.WriteLine($"Name : {birth.Name}");
                Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
                Console.WriteLine($"Age : {birth.Age}");
            }
        }
    }