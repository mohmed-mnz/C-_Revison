using System.Collections;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
namespace Rev
{
    public partial class Program
    {
        #region Variables 
        //static int Size;
        //static int x,y; 
        #endregion

        //public delegate bool Filter<in T>(T n);
        static void Main(string[] args)
        {
            #region Single Dimintional Array
            //declare 
            //WriteLine("Please Enter ur array size");
            //size =int.Parse(ReadLine());
            //int[] arr=new int[size];
            ////intialize the array 
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    WriteLine($"please enter ur {i+1}th number");
            //    arr[i] = int.Parse(ReadLine());
            //}
            //Array.Sort(arr);

            ////print the array
            //for(int i = 0;i < arr.Length;i++)
            //{
            //    Write($"({ arr[i]}),");
            //}
            #endregion

            #region Multi Dimintional Array
            //Declare
            //WriteLine("Please Enter ur array number Rows ");
            //x = int.Parse(ReadLine());
            //WriteLine("Please Enter ur array number columns");
            //y = int.Parse(ReadLine());
            //int[,] ARR = new int[x, y];
            ////intialize
            //for (int i = 0; i < ARR.GetLength(0); i++)
            //{

            //    for (int j = 0; j < ARR.GetLength(1); j++)
            //    {
            //        WriteLine($"please enter ur num{j}th");
            //        ARR[i, j] = int.Parse(ReadLine());

            //    }
            //}
            ////Array.Sort( ARR );
            ////print
            //WriteLine();
            //WriteLine("----------------------------------------------");
            //WriteLine("this is Ur 2D Array ");
            //for (int i = 0; i < ARR.GetLength(0); i++)
            //{
            //    for(int j = 0;j < ARR.GetLength(1); j++)
            //    {
            //        Write($"({ARR[i,j]}),");
            //    }
            //    WriteLine(" ");
            //}
            #endregion

            #region Delegate
            //var emp = new Employee[]
            //{
            //    new Employee{Id=1,Name="Ahmed",Address="Al_Salam",City="Cairo",salary=35000},
            //    new Employee{Id=2,Name="Mariam",Address="Toukh",City="qalubia",salary=50000},
            //    new Employee{Id=3,Name="Tarek",Address="Abbas-Elaqad",City="Cairo",salary=75000},
            //    new Employee{Id=4,Name="Mohamed",Address="Minya-Elqamh",City="Sharqia",salary=11500},
            //    new Employee{Id=5,Name="Mostafa",Address="Sharm-Elsheikh",City="sharm",salary=20500},
            //    new Employee{Id=6,Name="Eman",Address="Zagszig",City="sharqia",salary=25000},
            //};
            //var repo = new Report();
            #region Lemd Expression
            //repo.Employeeprocess(emp, "Grater than 11500$", e => e.salary > 11500);
            //repo.Employeeprocess(emp, "Between 11500$ && 50000$ ", e => e.salary >= 11500 && e.salary < 50000);
            //repo.Employeeprocess(emp, "Grater than 11500$", e => e.salary > 50000); 
            #endregion
            #endregion

            #region Events
            //var stock =new stockmarket("Amazon");
            //stock.Price = 100;
            //stock.OnPriceChanged += /*Stock_OnPriceChanged*/     /*using lemda expression to fire event */(stockmarket s,decimal _price) =>
            //{
            //    if (s.Price > _price)
            //    {
            //        ForegroundColor = ConsoleColor.Green;

            //    }
            //    else if (_price > s.Price)
            //    {
            //        ForegroundColor = ConsoleColor.Red;
            //    }
            //    else
            //    {
            //        ForegroundColor = ConsoleColor.Gray;
            //    }

            //    WriteLine($"{s._name} :: {s.Price}");
            //};
            //stock.changeed(0.05m);
            //stock.changeed(-0.03m);
            //stock.changeed(0.00m);


            /*out of the main */

            //private static void Stock_OnPriceChanged(stockmarket s, decimal _price)
            //{
            //    if (s.Price > _price)
            //    {
            //        ForegroundColor = ConsoleColor.Green;

            //    }
            //    else if(_price > s.Price)
            //    {
            //        ForegroundColor = ConsoleColor.Red;
            //    }
            //    else
            //    {
            //        ForegroundColor = ConsoleColor.Gray;
            //    }

            //    WriteLine($"{s._name} :: {s.Price}");
            //}

            //public delegate void StockPriceChangeHandler(stockmarket s ,decimal _price);
            //public class stockmarket //publisher
            //{
            //    private string name;
            //    private decimal price;
            //    /*Event Declare*/
            //    public event /*Data Type*/ StockPriceChangeHandler  OnPriceChanged;

            //    public string _name =>  this.name;
            //    public decimal Price { get=>this.price; set=>this.price=value;}
            //    public stockmarket(string nameS)
            //    {
            //        this.name = nameS;
            //    }
            //    public void changeed(decimal _percent)
            //    {
            //        decimal oldprice = this.price;
            //        this.price += Math.Round(this.Price * _percent, 2);
            //        if(OnPriceChanged != null)//make sure there is subscriber
            //        {
            //            OnPriceChanged(this, oldprice); //fire Event
            //        }
            //    }
            //}
            #endregion

            #region operator overloading
            //Money m = new Money(10);
            //Money m1 = new Money(1000);
            //Money m2 = m+m1;
            //WriteLine($"Money m = {m.Amount}");
            //WriteLine($"Money m1 = {m1.Amount}");
            //WriteLine($"Money m1 = {m2.Amount}" );
            #endregion

            #region Interface
            //vehicle v1 = new BMW("BMW","BMW2010",2010);
            //WriteLine(v1);
            //casher c =new casher(new cash());
            //c.checkout(999.999m);
            #endregion

            #region Generics
            //WriteLine("Please Enter Your Number: ");
            //while (true)
            //{
            //    if (int.TryParse(ReadLine(), out var x))
            //    {
            //        value(x);
            //        break;
            //    }
            //    else
            //    {
            //        WriteLine("Please enter a valid number:");
            //        Console.WriteLine("");
            //    }
            //
            //var x=ReadLine();

            //value( x);
            //var numbers= new any<int>();
            //numbers.add(1);
            //numbers.add(2);
            //numbers.add(3);
            //numbers.add(4);
            //numbers.add(5);
            //numbers.display();
            //numbers.remove(0);
            //numbers.remove(1);
            //numbers.display();
            //var person = new any<person>();
            //person.add(new person("Ahmed", "Mohsen"));
            //person.add(new person("Mohamed", "Tarek"));
            //person.add(new person("Eman", "Tarek"));
            //person.remove(0);
            //person.display();
            //var people=new List<person>();
            //people.Add(new person("Mohamed", "alaa"));
            //foreach(var item in people)
            //{
            //    Console.WriteLine(item);
            //}
            //var arr= new ArrayList();

            #endregion

            #region Generic Delegate
            //IEnumerable<int>arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //displayNum(arr,n=>n<6,()=>Console.WriteLine( "Numbers less tahn 6"));
            //WriteLine();
            //displayNum(arr, n => n < 7, () => Console.WriteLine("Numbers less tahn 7"));
            //WriteLine();
            //displayNum(arr, n => n % 2 == 0, () => Console.WriteLine("Numbers even is: "));
            //WriteLine();
            //IEnumerable<decimal> arr1 = new decimal[] { 1.1m, 2.1m, 3.3m, 4.4m, 5.5m, 6.6m, 7.7m, 8.8m, 9.9m };
            //displayNum(arr1, n => n % 2.2m == 0, () => Console.WriteLine("Numbers even is: "));

            //Action<string> action = Print;
            //Func<int, int, int> func = add;
            //Predicate<int> evennum = iseven;
            //WriteLine();
            //WriteLine(func(2,1));
            //WriteLine(evennum(31));
            #endregion
        }
        #region Generics
        /*Generic  Method*
        static void value <T>(T value)
        {
            WriteLine($"this is ur number {value}");
        }
        */
        /*Generic class*/
        //class person
        //{
        //    private string fname;
        //    private string lname;
        //    public person()
        //    {

        //    }
        //    public person(string Fname,string Lname)
        //    {
        //        fname = Fname;
        //        lname = Lname;
        //    }
        //    public override string ToString()
        //    {
        //        return $"{fname} , {lname} \n";

        //    }
        //}
        //class any<T> where T:class, new()
        //{
        //    private T[] items;
        //    public void add(T item)
        //    {
        //        if(items is null)
        //        {
        //            items = new T[] { item};

        //        }
        //        else
        //        {
        //            var length = items.Length;
        //            var dist=new T[length+1];
        //            for(var i=0; i<length; i++)
        //            {
        //                dist[i] = items[i];
        //            }
        //            dist[dist.Length- 1] = item;
        //            items = dist;
        //        }
        //    }
        //    public void remove(int item)
        //    {
        //        if (item < 0||item>items.Length-1)
        //        {
        //            return;
        //        }
        //        var length = 0;
        //        var dist = new T[items.Length - 1];
        //        for (var i=0; i < items.Length; i++)
        //        {
        //            if (item == i)
        //            {
        //                continue;
        //            }
        //            dist[length++] = items[i];
        //        }
        //        items = dist;
        //    }
        //    public  bool isempty => items is null || items.Length == 0;
        //    public int count =>items is null? 0 : items.Length;  /*ternery operator*/ 
        //    public void display()
        //    {
        //        Write("{ \n");
        //        for(var i=0; i < items.Length; i++)
        //        {
        //            Write(items[i]);
        //            if (i > items.Length - 1)
        //            {
        //                Write(",");
        //            }
        //        }
        //        WriteLine("}");
        //    }
        //}
        #endregion

        //static void displayNum<T>(IEnumerable<T>list, /*Filter<T>*/ /*Predicate<int>*/ Func<T,bool> filter,Action action )
        //{
        //    action(); 
        //    foreach(var item in list)
        //    {
        //        if (filter(item))
        //        {
        //            Write("  "+ item+ " " );
        //        }
        //    }
        //}
        #region Generic functions
        //static void Print(string name)=>Console.WriteLine(name);
        //static int add(int x, int y) => x + y;

        //static bool iseven(int num) => num % 2 == 0;
        #endregion
    }
} 