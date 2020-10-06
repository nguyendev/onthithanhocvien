using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenIT.Quiz.Pages
{
    public class DefaultPage: PageModel
    {
        public string GetTitle(int year, int number)
        {
            switch(year)
            {
                case 1:
                    switch (number)
                    {
                        case 1:
                            return "Tổng quan về Kinh Thánh";
                        case 2:
                            return "Lẽ mầu nhiệm của sự cứu rỗi";
                        case 3:
                            return "Lược sử Hội Thánh";
                        case 4:
                            return "Đạo Đức Cơ Đốc";
                        case 5:
                            return "Chia sẽ niềm tin";

                        default:
                            return "";
                    }
                case 2:
                    switch (number)
                    {
                        case 1:
                            return "Cuộc đời Chúa Cứu Thế Giê-xu";
                        case 2:
                            return "Lẽ mầu nhiệm của sự cứu rỗi 2";
                        case 3:
                            return "Lược sử HTTL Việt Nam";
                        case 4:
                            return "Nếp sống CĐN";
                        case 5:
                            return "Phương pháp học Kinh Thánh";

                        default:
                            return "";
                    }

                default:
                    return "";
                      
            }
        }
    }
}
