using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LineCheck
{
    public class Check
    {
        public bool CheckNumbers(string password)
        {
            return Regex.IsMatch(password, @"\d");
        }

        public bool CheckLowerLetters(string password)
        {
            return Regex.IsMatch(password, @"[a-z]");
        }

        public bool CheckUpperLetters(string password)
        {
            return Regex.IsMatch(password, @"[A-Z]");
        }

        public bool CheckSpecialChars(string password)
        {
            return Regex.IsMatch(password, @"[\W_]");
        }

        public bool CheckLenhts(string password)
        {
            return password.Length > 10;
        }

        public int GetPasswordPoint(string password)
        {
            int point = 0;

            if (CheckNumbers(password))
                point++;
            if (CheckLowerLetters(password))
                point++;
            if (CheckUpperLetters(password))
                point++;
            if (CheckSpecialChars(password))
                point++;
            if (CheckLenhts(password))
                point++;

            return point;
        }

    }
}
