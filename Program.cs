using System;

namespace OperatorAssessment
{

    //Must be both static and public


    //Operator Polymorphism
        //Operator Interface -- 
        //Virtual Operator -- DOES NOT WORK because Virtual cannot work with static methods
        //Abstract Operator -- DOES NOT WORK because Abstract does not work together with static methods

    //Operator with Delegates
        //Operator with Events
        //Operator with Lambda

    //Operator with Generics -- Also does not work, since we cannot instantiate the generic class that the operator is a method
    //of at runtime.

    //Operator with Queues



    class Program
    {
        static void Main(string[] args)
        {

            new PolymorphicOperator();



            new ExecuteDemoQueue();
        }
    }
}
