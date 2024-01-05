using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGitForProgrammers
{
    public class Calculator
    {
        // 加法
        public int Add(int left, int right)
        {
            return left + right;
        }

        // 減法
        public int Subtract (int left, int right)
        {
            return right - left;
        }

        public int Multiply (int left, int right)
        {
            return left * right;
        }

        public int Divide (int left, int right)
        {
            return left / right;
        }
    }
}
