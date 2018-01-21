using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic Method implementation

            Console.WriteLine("=======Generics Implementation======");
            int a = 2;
            int b = 3;
            Stack.Swap(ref a, ref b);
            Console.WriteLine("swap numbers are a=" + a + " n b=" + b);
            Console.ReadLine();



            /// Extension methods
            Console.WriteLine("=======Extension Mehtods Implementation======");
            A a1 = new A();
            B b1 = new B();
            C c1 = new C();


            a1.MethodA(1);
            a1.MethodA("Hello");
            Console.ReadLine();


            Console.WriteLine("=======Extension Mehtods Implementation======");
            string strName = "pragim";
            string result = strName.ChanegFirstLetterCase();
            StringHelper.ChanegFirstLetterCase(strName);
            Console.WriteLine(strName);
            Console.ReadLine();



            Console.WriteLine("======= Delegat Implementation======");

            //creating instanse of a delegate
            // type safe function pointer : the signature of delegate should match the type of the function
            HelloFunctionDelegate del = new HelloFunctionDelegate(Delegates.Hello);
            del("hey this is ali");
            Console.ReadLine();


            Console.WriteLine("======= Anonymouse Method Implementation======");

            List<Employee> objList = new List<Employee>
            {
                new Employee{ID = 101,Name = "Mark"},
                new Employee{ID = 102,Name = "John"},
                new Employee{ID = 103,Name = "Marry"},
            };

      
            // Anonymouse method is a method without name, the provide us a way of creating delegate instances without having to write a seperate method.
            Employee employee = objList.Find(   
                
                delegate (Employee emp)
                {
                    return emp.ID == 102;
                }
            );



            Console.WriteLine("Id = {0}, Name = {1}", employee.ID, employee.Name);
       

        }
    }



    #region ExtensionMethodCode

    class A : IMyInterface
    {
        void IMyInterface.MethodB()
        {
            Console.WriteLine("B.MethodB()");
        }
    }


    class B : IMyInterface
    {
        public void MethodB()
        {
            Console.WriteLine("B.MethodB()");
        }

        public void MethodA(int i)
        {
            Console.WriteLine("B.MethodA(int i)");
        }
    }


    class C : IMyInterface
    {
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }

    #endregion


    #region AonymouseMethodCode

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
    #endregion



}