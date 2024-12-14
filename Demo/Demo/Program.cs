using System.Text;

namespace Session_04_Demo
{
    class Person
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            #region String [Name [2]]
            ////String --> is a reference type [Class]
            ////Immutable
            ////Is an array of characters
            //string Name1;
            //Stack [4 bytes]
            //Heap  [0 Bytes]
            //Refernce refer to null
            //Name1 = new string("Mariam"); // 12 Bytes in heap
            //Name1 = "Mariam"; //Syntax sugar
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name1.GetHashCode());
            //string Name2 = "Mariam";
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name2.GetHashCode());

            #region 1
            //string Name1 = "Mariam";
            //string Name2 = "Amira";
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Name2 = Name1;
            //Console.WriteLine("**************After = **************");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Name1 = "MariamYasser";
            //Console.WriteLine("**************After Changing Name1 **************");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            #endregion

            #region 2
            //string Message = "Hello"; //Unreachable
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //Console.WriteLine("**************After Change **************");
            //Message += " Mariam";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            #endregion

            #endregion

            #region StringBuilder
            //StringBuilder --> is a reference type [Class]
            //Mutable
            //is a linkedList
            //StringBuilder Name1 = new StringBuilder("Mariam");
            //StringBuilder Name2 = new StringBuilder("Amira");
            //Name2.Append("Amira");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Console.WriteLine("******************************");
            //Name2 = Name1;
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Console.WriteLine("******************************");
            //Name1.Append(" Yasser");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            #endregion

            #region StringBuilderMethods
            // Name1.AppendLine(" Yasser");
            // Name1.Append("Hello");
            // //Console.WriteLine(Name1);
            // Name1.Insert(0, "Hello ");
            // Name1.Remove(0, 5);
            //// Console.WriteLine(Name1);
            // //Console.WriteLine("******************************");

            // Name1.Replace("Hello", "HelloNew");
            // //Console.WriteLine(Name1);

            // Name1.Clear();
            // Console.WriteLine(Name1);
            #endregion


            #region Arrays
            #region 1D Array
            #region 1
            ////Array is a class [Refernce type]
            //int[] Numbers;
            //Refer to null
            //4 bytes in stack
            //0 bytes in heap
            //Numbers = new int[5];
            //Allocate number of bytes needed in heap 20bytes
            //Intialize with default value of its datatype [0]
            //Call user-defined consrtucor if exist
            //Refer from stack to heap[Refernce]
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //Numbers[0] = 10;
            //Numbers[1] = 20;
            //Numbers[2] = 30;
            //Numbers[3] = 40;
            //Numbers[4] = 50;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //int[] Numbers1 = new int[5] { 10, 20, 30, 40, 50 };
            //int[] Numbers2 = new int[] { 10, 20, 30, 40, 50 };
            //int[] Numbers3 = { 10, 20, 30, 40, 50 };
            //int[] Numbers4 = [1, 2, 3, 4]; 
            //int[] Numbers3;
            ////Numbers3 = { 10 , 20 , 30}; //Invalid
            //Console.WriteLine($"The length ==> {Numbers3.Length}");
            //Console.WriteLine($"The rank ==> {Numbers3.Rank}");
            //for (int i = 0; i < Numbers.Length ; i++)
            //{
            //    Console.WriteLine(Numbers3[i]);
            //}
            #endregion
            #endregion

            #region 2D Array -  Rectangular
            #region 1
            //int[,] Marks = new int[3, 5] /*{{1 , 2 , 3 , 4 , 5 } ,{6 , 7 , 8 , 9 , 1 } ,{2 , 3 , 4 , 5, 6  } }*/;
            //Console.WriteLine(Marks.Length);
            //Console.WriteLine(Marks.Rank);
            //Student number 1 [With index 0]
            //Marks[0,0] = 100;
            //Marks[0,1] = 99;
            //Marks[0,2] = 88;
            //Marks[0,3] = 99;
            //Marks[0,4] = 100;

            //Marks[1, 0] = 100;
            //Marks[1, 1] = 99;
            //Marks[1, 2] = 88;
            //Marks[1, 3] = 99;
            //Marks[1, 4] = 100;

            //Marks[2, 0] = 100;
            //Marks[2, 1] = 99;
            //Marks[2, 2] = 88;
            //Marks[2, 3] = 99;
            //Marks[2, 4] = 100;

            //bool flag;
            //int Grade;
            //for(int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Please enter the grades for student number {i + 1}");
            //    for(int j = 0; j < Marks.GetLength(1); )
            //    {
            //        Console.WriteLine($"Please enter the grade for subject number {j + 1}");
            //        j = int.TryParse(Console.ReadLine(), out Grade) ? ++j : j;

            //    }
            //    Console.WriteLine("*********************************");
            //}
            #endregion
            #endregion
            #endregion
        }
    }
}
