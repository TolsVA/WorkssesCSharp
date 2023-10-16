using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Calculator
    {
        public double div(double x, double y){
            Console.Write(x + " / " + y + " = ");
            return x / y;
        }
    
        public double work(double x, double y){
            Console.Write(x + " * " + y + " = ");
            return x * y;
        }

        public double sum(double x, double y){
            Console.Write(x + " + " + y + " = ");
            return x + y;
        }
    }