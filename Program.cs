internal partial class Program
{
    private static void Main(string[] args)
    {
         #region var
        var x = 16; // implict typed local variable
                    // more better use:
                    // Dictionary<int,List<int>> = new Dictionary<int,List<int>>(); ====> 
                    //var dic = new Dictionary<int, List<int>>(); 
        #endregion

        #region Extension method
        // deafult way 
        int a = 12345;
        int y = INT64E.mirror(a);
        //Console.WriteLine(y);
        //convert to extinsion method 1-make the class static 2- add "this to the param"
        int z = a.mirror();
        Console.WriteLine(z);

        #endregion

        #region Anonymous type
        /// Anonymous type
        var e1 = new { id = 2000, name = "yahia" };
        var e2 = new { id = 2000, name = "yahia" };
        /////Same DT as long as Same Property Names (With same Charcter Case) , same Property Type , same Sequence
        //e2.name= e1.name;// immutable type

        var e3 = new { name = "yahia", id = 2020 }; /// not the same DT , new anonymous datatype

        Console.WriteLine(e1.GetType().Name); ///<>f__AnonymousType0`2
        Console.WriteLine(e2.GetType().Name);///<>f__AnonymousType0`2
        Console.WriteLine(e1);
        Console.WriteLine(e2);
        Console.WriteLine(e3.GetType().Name); ///<>f__AnonymousType1`2
        Console.WriteLine(e1.Equals(e2));
        /// implictliy implemented 

        /// GetHashCode based on vlaue not identity
        Console.WriteLine(e1.GetHashCode());
        Console.WriteLine(e2.GetHashCode());
        Console.WriteLine(e3.GetHashCode());
        #endregion


        #region LINQ
        List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        IEnumerable<int> Result = Enumerable.Where(lst, i => i % 2 != 0);
        Console.WriteLine(Result);

        /// Fluent syntax:
        /// static function in Enumerable class
        var result = Enumerable.Where(lst, i => i % 2 != 0);

        Console.WriteLine(result);

        /// Extension Method
        var res = lst.Where(i => i % 2 != 0);
        Console.WriteLine(res);

        /// Query Expression \\ SQL LIKE
        var R = from i in lst
                where i % 2 != 0
                select i;
        ///  sql like syntax , valif for only subset of 40+ LINQ operation 
        ///  it's easier in some cases vs fluent syntax (join , group ,let ,into )
        ///  start with From , introduce range variable (i) : represent each and every element in input sequence
        ///  end with select or group by 
        Console.WriteLine(R);
        #endregion 
        //Most of LINQ Operators , Deffered Execution 
        var ls = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var resl = ls.Where(i => i % 2 == 0);
        foreach(var item in resl)
        {
            Console.Write($"{item} ,");
        }
        Console.WriteLine();
        ls.Remove(2);
        ls.AddRange(new int[] { 10, 11, 12, 13 });

        foreach (var item in resl)
        {
            Console.Write($"{item} ,");
        }

        ///Imidiate Execution
        ///Casting , Element Operators are Imidiate Execution Operators
        List<int> MyLst = ls.Where(i => i > 7).ToList();
    }
}