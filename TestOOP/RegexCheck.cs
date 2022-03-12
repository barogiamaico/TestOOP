using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestOOP
{
    public  class RegexCheck
    {
        public bool checkID(string id)
        {
            if (id.Length < 3 || id.Length > 10)
            {
                Console.WriteLine("Phai nhap tu 3-10 ki tu");
                return false;
            }
            else if (id.Contains(" "))
            {
                Console.WriteLine("Khong duoc chua khoan trang ");
                return false;
            }
            bool matchRegex = Regex.IsMatch(id, @"^[a-zA-Z0-9]+$");
            if (!matchRegex)
                return false;
            return true;
        }
        public  bool checkText(string text)
        {
            bool matchRegex = Regex.IsMatch(text, @"^[a-zA-Z\s]+$");
            if (!matchRegex)
                return false;
            return true;
        }
        public bool onlyLettersAndSpaces(string text)
        {
            bool matchRegex = Regex.IsMatch(text, @"^[a-zA-Z\s]*$");
            if (!matchRegex)
                return false;
            return true;
        }
       public bool onlyNumberAndLetters(string text) 
        {
            bool matchRegex = Regex.IsMatch(text, @"^[a-zA-Z0-9\s]+$");
            if (!matchRegex)
                return false;
            return true;
        }
        public bool checkDate(string date)
        {
            bool matchRegex = Regex.IsMatch(date, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            
            if (date != null)
            {
                string []tempDate = date.Split("/");
            }
            return true;
        }
        public bool validate_date(string date, string date_format= "dd/MM/yyyy")
        {
            DateTime dt;
                bool valid = DateTime.TryParseExact(date, date_format, null, DateTimeStyles.None, out dt);
            if (!valid)
                return false;
            return true;
        }
    }
}
