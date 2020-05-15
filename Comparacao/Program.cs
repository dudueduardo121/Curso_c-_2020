using System;
using Comparacao.Services;
namespace Comparacao {

    delegate double BinarynumericaOperation(double n1, double n2);
    class Program {
        static void Main(string[] args) {

            double a = 10;
            double b = 12;

            BinarynumericaOperation op = CalculetionService.Max;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
