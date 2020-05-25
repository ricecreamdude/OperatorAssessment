using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OperatorAssessment
{


    //Implement the following:
        //Add a string into a queue through the + operator
        //Add two queues together using the + operator

        //Remove the first string from a queue using the - operator

    //Operators and Queues can be a demonstration of how to overload basic Operators.
    class DemoQueue
    {
        private Queue<string> line;

        public DemoQueue(Queue<string> q )
        {
            line = q;
        }

        //Add the string to the queue
        public static DemoQueue operator +(DemoQueue queue, string s)
        {
            Queue<string> q = new Queue<string>();

            foreach (string item in queue.line)
            {
                q.Enqueue(item);
            }

            q.Enqueue(s);
            return new DemoQueue(q);

        }
        //Divert oposite order to above function
        public static DemoQueue operator +(string s, DemoQueue queue)
        {
            return queue + s;
        }
        //Add a queue to a queue, using two 
        public static DemoQueue operator +(DemoQueue q, DemoQueue c)
        {
            Queue<string> data = new Queue<string>();

            foreach( string s in q.line) data.Enqueue(s);
            foreach( string s in c.line) data.Enqueue(s);

            return new DemoQueue(data);

        }

        public void Print()
        {
            foreach (string s in line)
            {
                Console.Write("{0} ",s);
            }
        }

    }

    class ExecuteDemoQueue
    {
        public ExecuteDemoQueue()
        {
            Queue<string> testOne = new Queue<string>();


            DemoQueue demo = new DemoQueue(testOne);


            Queue<string> testTwo = new Queue<string>();
            DemoQueue addDemo = new DemoQueue(testTwo);



            demo = demo + "potato";
            demo = "bears" + demo;

            addDemo = addDemo + "HELLO";
            addDemo = addDemo + "TIGERS";
            addDemo = addDemo + "BEARS";

            demo = demo + addDemo;

            demo.Print(); //Expect potato bears HELLO TIGERS BEARS


        }



    }
}
