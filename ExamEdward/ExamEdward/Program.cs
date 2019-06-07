using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEdward
{
    class Program
    {
        // while
        // if
        // for
        // data types > int decimal char string bool datetime
        // cast > int.tryParse()
        // Arrays
        static void Main(string[] args)
        {
            getasciicode();

            getspace();

            getnumberlenght();
            
            getGreatestValue();

            
            getgrade();

            // Makes the console wait for input
            Console.ReadKey();
        }

        /// <summary>
        /// try
       // {               
         //   ProcessString(s);
   // }
       // catch (Exception e)
      //  {
          //  Console.WriteLine("{0} Exception caught.", e);
      //  }
/// </summary>





//print ascii cod (10) per line 

private static void getasciicode()

        {



            for (int i = 1; i < 123; i++)
            {
                Console.Write(i + " = " + "\t" + (char)i);

                if (i % 10 == 0)
                {

                   
                    // Console.WriteLine("Please press any key to turn page");
                    Console.Write((char)10);

                    
                    // Console.ReadKey();
                    //Console.Clear();
                }
            }

            Console.ReadKey();

        }


            /// <summary>
            // Space counting  
            /// </summary>
            private static void getspace()

        {

            string str;
            int i, len, vow;

            Console.Write("Enter string to count space:\n");
            Console.Write("----------------------------------------------\n");

            str = Console.ReadLine();

            vow = 0;
          
            len = str.Length;


            for (i = 0; i < len; i++)
            {
                if ((str[i] >= ' ' && str[i] <= ' ') || (str[i] >= ' ' && str[i] <= ' '))
                {
                    vow++;
                }

               
            }

      
            Console.Write("The total number of spaces between each character : {0}\n", vow);


        }


        /// <summary>
        /// character counting 
        /// </summary>

        public static void getnumberlenght()
        {
            string str;
            int i, len, vow, cons;

            Console.Write("Enter integer to count character :\n");
            Console.Write("----------------------------------------------\n");
            
            str = Console.ReadLine();

            vow = 0;
            cons = 0;
            len = str.Length;


            for (i = 0; i < len; i++)
            {
                if ((str[i] >= ' ' && str[i] <= ' ') || (str[i] >= ' ' && str[i] <= ' '))
                {
                    vow++;
                }

                else
                cons++;
            }

            Console.Write("\nThe total number of  string is : {0}\n", cons);
            Console.Write("The total number of spaces between each character : {0}\n", vow);
        }


        /// <summary>
        /// grade 
        /// </summary>

            private static void getgrade()
        {

            int Num1, Num2, Num3, total;

            float percentage;

            char option;

            Console.WriteLine("Enter the Marks of all subjects: ");

            Console.Write("Enter the Subject1 Marks:");

            Num1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the Subject2 Marks: ");

            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Subject3 Marks: ");

            Num3 = Convert.ToInt32(Console.ReadLine());

            total = Num1 + Num2 + Num3;

            percentage = total / 3;

            if (percentage >= 90)

            {

                option = '1';

            }


            else if (percentage >= 70)

            {

                option = '2';

            }

            else if (percentage >= 50)

            {

                option = '3';

            }

          

            else

            {

                option = '4';

            }



            Console.WriteLine("The RESULT of Student with GRADE:");

         

            Console.WriteLine("TOTAL Marks:{0}", total);

            Console.WriteLine("PERCENTAGE: {0}", percentage.ToString());


            switch (option)

            {

                case '1':

Console.WriteLine("Grade: A");

                    break;

                case '2':

Console.WriteLine("Grade: B");

                    break;

                case '3':

Console.WriteLine("Grade: C");

                    break;

                case '4':

Console.WriteLine("Grade: F");

                    break;



                default:

                    Console.WriteLine("Invalid GRADE");

                    break;

            }




        }









        /// <summary>
        /// array and if (greatest value )
        /// </summary>
        /// <returns></returns>
        public static int getGreatestValue()
        {
            int greatestVal = 0;

            Console.WriteLine("Enter value 1");
            int val1 = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out val1);
            Console.WriteLine("");

            Console.WriteLine("Enter value 2");
            int val2 = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out val2);
            Console.WriteLine("");

            Console.WriteLine("Enter value 3");
            int val3 = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out val3);
            Console.WriteLine("");

            int[] arrTemp = new int[3];
            arrTemp[0] = val1;
            arrTemp[1] = val2;
            arrTemp[2] = val3;

            Array.Sort(arrTemp);

            Console.WriteLine(arrTemp[2].ToString());


            
            if (val1 > val2)
                if (val3 > val1)
                    greatestVal = val3;
                else
                    greatestVal = val1;
            else
            {
                if (val3 > val2)
                    greatestVal = val3;
                else
                    greatestVal = val2;
            }

            Console.WriteLine("Greatest value is " + greatestVal.ToString());

            return greatestVal;
        }

    }







    //product of array




}


