using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OperatorAssessment
{
    class InterfaceOperator
    {
        interface IShape
        {
            //By default this is public so we need to define it as public in the interited class
            int Area { get; }
        }
        class Rectangle : IShape
        {
            int width;
            int height;

            public Rectangle( int w, int h)
            {
                width = w;
                height = h;
            }

            public int Area => width * height;

            //We can't directly use Interface to provide an Operator solution, since Operator needs to be static and reference itself.
            public static Rectangle operator +(Rectangle x, Rectangle y)
            {
                return new Rectangle(x.width, y.width);
            }

        }

    }
}
