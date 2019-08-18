using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ComplexNumber
    {
        public double real;
        public double imaginary;

        public ComplexNumber(double _real, double _imaginary)
        {
            real = _real;
            imaginary = _imaginary;
        }

        public string output()
        {
            return $"{real} + {imaginary}i";
        }

        #region multiplication
        public static ComplexNumber operator *(ComplexNumber one, ComplexNumber two)
        {
            return new ComplexNumber(one.real * two.real - one.imaginary * two.imaginary, one.real*two.imaginary + one.imaginary*two.real);
        }
        #endregion
        #region division
        public static ComplexNumber operator /(ComplexNumber one, ComplexNumber two)
        {
            return new ComplexNumber((one.real*two.real + one.imaginary*two.imaginary)/(two.real * two.real + two.imaginary*two.imaginary),
                (two.real*one.imaginary - one.real*two.imaginary)/(two.real *two.real + two.imaginary*two.imaginary));
        }
        #endregion
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st real: ");
            int real1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 1st imaginary: ");
            int im1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd real: ");
            int real2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd imaginary: ");
            int im2 = Convert.ToInt32(Console.ReadLine());

            ComplexNumber one = new ComplexNumber(real1, im1);
            ComplexNumber two = new ComplexNumber(real2, im2);

            Console.WriteLine($"Multiplication result: {(one * two).output()}");         
            Console.Write($"Division result: {(one / two).output()}");
          
            Console.ReadKey();
        }
    }
}
