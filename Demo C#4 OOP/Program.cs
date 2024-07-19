using Demo_C_4_OOP.Interfaces;
using Demo_C_4_OOP.Interfaces.IClonable;
using System;

namespace Demo_C_4_OOP
{
    internal class Program
    {
        public static void Print10Numbers(ISeries seriesBy2)
        { if(seriesBy2 != null)
            {
                for(int i=0; i<10; i++)
                {
                    Console.Write($"  {seriesBy2.Current}  ");
                    seriesBy2.GetNext();
                }
                seriesBy2.Reset();
            }

        }



        static void Main(string[] args)
        {

            #region Interface
            IMyType myType;
            IMyType myType1 = new MyType();
            myType1.Id = 1;
            myType1.MYFun(50);
            myType1.Print();
            #endregion

            #region Ex Interface
            Series  seriesBy2 = new Series();
            Print10Numbers(seriesBy2);

            Console.WriteLine( "\n ============");

            SeriesBy3 seriesBYThree = new SeriesBy3();
            Print10Numbers(seriesBYThree);

            #endregion

            #region Interface EX02 
            car Car = new car();
            Car.Backward();

            AirPlane airPlane = new AirPlane();
            airPlane.Backward();

            IFlyable flyablePlane = new AirPlane();
            flyablePlane.Forward();
            IMovable movablePlane = new AirPlane();
            movablePlane.Forward();

            #endregion

            Console.WriteLine("================================");
            
            #region Shallow Copy & DeeP Copy 

            #region Array Of Value Type 
            int[] Arr01 = {1,2,3};
            int[] Arr02 = new int[3];
            Console.WriteLine($"Arr01 HC:{Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02 HC:{Arr02.GetHashCode()}");
            Arr02 = Arr01;
            Console.WriteLine($"Arr02 is {Arr02[0]}");
            Arr02[0] = 200;
            Console.WriteLine($"Arr01 is: {Arr01[0]}");
            Console.WriteLine($"Arr02 is: {Arr02[0]}");




            #endregion


            #region Deep Copy




            #endregion



            #endregion

            Console.WriteLine("==========================================");
            #region array of ref
            String[] Names01 = { "Omar" };
            String[] Names02 = new String[1];
            Console.WriteLine($"HC Of Names01:{Names01.GetHashCode()}");
            Console.WriteLine($"HC Of Names02:{Names02.GetHashCode()}");

            Names02=Names01;
            Console.WriteLine("After Shallow Copy  ");
            Console.WriteLine($"HC Of Names01:{Names01.GetHashCode()}");
            Console.WriteLine($"HC Of Names02:{Names02.GetHashCode()}");

            Console.WriteLine($"Names01[0]: {Names01[0]}");
            Console.WriteLine($"Names02[0]: {Names02[0]}");

            Names02[0] = "Aya";

            Console.WriteLine($"Names01[0]: {Names01[0]}");
            Console.WriteLine($"Names02[0]: {Names02[0]}");
            #region
            Names02 = (string[]) Names01.Clone();

            Console.WriteLine("After Deep Copy  ");
            Console.WriteLine($"HC Of Names01:{Names01.GetHashCode()}");
            Console.WriteLine($"HC Of Names02:{Names02.GetHashCode()}");
            Names02[0] = "Omar";

            Console.WriteLine($"Names01[0]: {Names01[0]}");
            Console.WriteLine($"Names02[0]: {Names02[0]}");



            #endregion


            #endregion

            Console.WriteLine("=========================================");


            #region Clonable
            Employee employee01 = new Employee() { Id=10, Name="Aliaa", Salary= 30000} ;
            Employee employee02 = new Employee() { Id=20, Name="Ali", Salary= 50000} ;
            Console.WriteLine(employee01);
            Console.WriteLine(employee02);

            #region Clonable Shallow Copy
            employee02 =employee01 ;
            Console.WriteLine("After Shallow Copy ");
            Console.WriteLine($"employee01 {employee01}" );
            Console.WriteLine($"employee02 {employee02}" );

            employee01.Name = "Aya";
            employee01.Id = 30;
            employee01.Salary = 6000;
            Console.WriteLine("After changing in shallow Copy ");
            Console.WriteLine($"employee01 {employee01}");
            Console.WriteLine($"employee02 {employee02}");


            #endregion

            #endregion





        }
    }
}
