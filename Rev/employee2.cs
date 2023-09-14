namespace Rev
{
    public partial class Program
    {
        #region list
        //static void print (List<Country> country)
        //{
        //    foreach(var item in  country)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    //prop
        //    Console.WriteLine($"Count : {country.Count}");//actual count
        //    Console.WriteLine($"Capacity : {country.Capacity}");//intial Capacity for inner DS
        //} 
        #endregion

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

        public class employee 
        {
            public int  Id{ get; set; }
            public string  Name{ get; set; }
            public int?  Report_To{ get; set; }
            public override string ToString()
            {
                return $"[{Id}]:{Name}";
            }
        }
    }
}