using System;

namespace MathComponentLib
{
    public class Calculator
    {
        public int CubeEvenNum(int num)
        {
            if (IsEvenNum(num))
                return num * num * num;
            else
                throw new Exception("Number is not Even");
        }

        private bool IsEvenNum(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
