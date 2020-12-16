using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class Program 
{
    public static void Main()
    {
        var items = Enumerable.Empty<int>();

        var dummy = new MyClass();

        var result = from x in items
                    where x == dummy.Id
                    select x;
    }
}

public class MyClass
{
	internal int Id { get; set; }
}

public static class Extensions
{
	public static bool Where(this IEnumerable<int> enumerable, Expression<Func<int, bool>> predicate)
	{
		throw new NotImplementedException("It works, if this is reached!");
	}
}