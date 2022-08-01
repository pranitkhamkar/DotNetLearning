using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsApp
{
    public class MathEngine
    {
        double result;
        const double PI = 3.14;
        readonly string id;
        public MathEngine()
        {
            //GUID: Globally Unit Identifier
            //128 bit number
            id=Guid.NewGuid().ToString();
        }
        public double Result
        {
            get { return result; }
            set { result = value; }
        }
        public void Add(int num1, int num2)
        {    
            result = num1 + num2;
        }
        public void Subtrac(int num1, int num2)
        {
            result = num1 - num2;
        }
        public void Swap( ref int num1, ref int num2)
        {
            //Swaping of two numbers
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

        }

        public  double  Area( int radius)
        {
            double area = PI * radius * radius;
            return area;
        }

        public double Circumference(int radius)
        {
            double circum = 2*PI * radius ;
            return circum;
        }
        public void CalculateCircle( int radius, out double area, out double circum)
        {
            area =  PI * radius * radius ;
            circum = 2 * PI * radius;

        }

        public void Display(params object[] objects)
        {
            foreach(object obj in objects)
            {
                Console.WriteLine(obj);
            }
        }       
    }

    public class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; }
    }

    public class BookShelf
    {
        private string[] books=new string[5];

        //Custom indexer 
        //You can write only one indexer for class
        public string this[int index]
        {
            get
            {
                return this.books[index];
            }
            set
            {
                this.books[index] = value;
            }
        }
        public BookShelf()
        {
            this.books[0] = "Let us C";
            this.books[1] = "Black Book Java";
            this.books[2] = "Rich Poor, Poor Dad";
            this.books[3] = "The Complete Reference C++";
            this.books[4] = "Head First Java";
        }

    }



    //Singleton   : Design Patterns
    // 23 design patterns are there 
    // Categories of Design Patterns
    //1.Structural Patterns
    //2.Creational Patterns
    //3.Behavioral Patterns

    public class OfficeBoy
    {
        private static OfficeBoy self = null;
        private string name;
        private OfficeBoy()
        {
            this.name = "Ravi Tambade";
        }

        public static OfficeBoy CreateInstance()
        {
            if(self == null)
            {
                OfficeBoy boy = new OfficeBoy();
                self = boy;
            }
            return self;
        }
    }

    public class Complex
    {
        public int Real { get; set; }
        public  int Imag { get; set; }
        public Complex(int r, int i)
        {
            this.Real = r;
            this.Imag = i;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex temp = new Complex(0, 0);
            temp.Real = c1.Real + c2.Real;
            temp.Imag = c1.Imag + c2.Imag;
            return temp;

        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex temp = new Complex(0, 0);
            temp.Real = c1.Real - c2.Real;
            temp.Imag = c1.Imag - c2.Imag;
            return temp;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            MathEngine math = new MathEngine();

            int num1 = 67;
            int num2 = 78;
            math.Swap( ref num1,  ref num2); // Pass by Refernce
            Console.WriteLine(num1 + num2);

            Console.WriteLine(" first Number= "+num1+ " , second Number="+ num2);

            int radius = 6;
            double area=56, circumference=0;
            Console.WriteLine(" Area= " + area + " , Circumference=" + circumference);

            math.CalculateCircle(radius, out area, out circumference);

            Console.WriteLine(" Area= " + area + " , Circumference=" + circumference);

            string fullName = "Ravi Tambade";
            string company = "Transflower";
            string email = "ravi.tambade@transflower.in";
            math.Display(fullName);
            math.Display(fullName, company, new Guid());
            math.Display(fullName, company, email,45);




            int[] marks = { 34, 76, 55, 45, 99 };
            string[] names = { "Sameer", "Supriya", "Manisha", "Swapnil" };

            Course[] pgDac = { 
                              new Course{Name="Java",Duration=60},
                              new Course{Name="DotNet", Duration=20}
            };

            int[] stocks=new int[5] { 45,76,34,65,34};

            Course theCourse = pgDac[1];
           
            //Recangular Array
            int [,]  matrix = new int[2,2]
            {
                {34,56 },
                {23,76 }
            };

            //Jagged Array
            //Array of Array

            int[][] studentMarks = new int[30][];
            studentMarks[0] =new int[] { 34, 76, 55, 45, 99 };
            studentMarks[1] = new int[] { 34, 76, 55 };
            studentMarks[2] = new int[] { 34, 76, 55,56,76,45,76 };
            studentMarks[3]= new int[] { 34, 76, 55, 56, 76, 45, 76 ,56,76,};
            studentMarks[4] = new int[] { 34, 76, 55, 56, 76, 45, 76 };
           
            foreach( int[]  i in studentMarks)
            {
                Console.WriteLine("");
               foreach (int num in i)
                {
                    Console.Write(num);
                }
            }

            BookShelf technicalBookShelf = new BookShelf();

            //Object refernce behave like an array
            string currentBook = technicalBookShelf[1];
            technicalBookShelf[2] = "Advanced Windows";


            //Nullable int type
            int? result =null;
            result = 56;

            Nullable<int> result2 = null;

            double? score = null;
            score = 45.5;
            Nullable<double> score2 = null;

            Course aiCourse = null;


            Complex c1 = new Complex(67, 87);
            Complex c2 = new Complex(88, 12);

            Complex c3 = c1 + c2;
            Complex c4 = c1 - c2;


            Console.ReadLine();
        }
    }
}
