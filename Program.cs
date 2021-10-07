using System;

namespace training2._1
{
    class Program
    {
       static public float BMI (float kg , float M)
        {
            float bmi =  (kg*100) / (M*M)*100;
            return bmi;
          
        }


        static void Main(string[] args)
        {
            int weight , stature;

            System.Console.WriteLine("Hello\n welcome to body BMI calculator.");
            System.Console.WriteLine("please enter your weight (kg):");

            weight = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("please enter your statue (m):");

            stature = Convert.ToInt32(System.Console.ReadLine());

           System.Console.WriteLine("your Body BMI is:"+ BMI(weight,stature)); 

           var A = BMI(weight,stature);

            System.Console.WriteLine("");

           if (A<=18.5)
           {
               System.Console.WriteLine("you are thin.");
           }
           if (A<=24.9)
           {
               if (A>18.5)
               {
                   System.Console.WriteLine("very good.\t Normal Body. ");
               }
           }
           if (A<=29.9)
           {
               if (A>24.9)
               {
                   System.Console.WriteLine("you have a little extra fat.");
               }         
           }
           if (A<=33.9)
           {
               if (A>29.9)
               {
                   System.Console.WriteLine("you are fat.");
               }
           }
           if (A<=35)
           {
               if (A>33.9)
               {
                   System.Console.WriteLine("you got extra fat."); 
               }
           }
           else
           {
               System.Console.WriteLine("you should see a doctor .");
           }
           
           Console.ReadKey();
           
           
        }

    }
}
