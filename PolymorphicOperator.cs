using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OperatorAssessment
{
    class PolymorphicOperator
    {

        public PolymorphicOperator()
        {
            Console.WriteLine("Polymoprhic Operator");

            Number testNum = new Number(15);

            testNum = +testNum;
            testNum.Log(); // should be 16

            testNum = -testNum;
            testNum.Log(); //Should Be  -16


        }



        public class Number
        {
            private int val;
            public Number( int x = 20) { val = x; }

            //Addition
            public static Number operator +(Number i) =>  new Number(i.val + 1);
            public static Number operator +(Number i, Number j) => new Number(i.val + j.val);

            //Subtraction
            public static Number operator -(Number i) => new Number( i.val - (i.val * 2) );
            public static Number operator -(Number i, Number j) => new Number(i.val - j.val);

            //Division // Overloading
            public static Number operator /(Number i, Number j) => new Number(i.val / j.val);
            public static Number operator /(Number i, int j) => new Number(i.val / j);
            public static Number operator /(int i, Number j) => new Number(i / j.val);

            //Multiplication //Overloading
            public static Number operator *(Number i, Number j) => new Number(i.val * j.val);
            public static Number operator *(int i, Number j) => new Number(i * j.val);

            public void Log() { Console.WriteLine(val); }


        }




    }
}
