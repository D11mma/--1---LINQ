class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int> { 402, 1005, 987, 21, 26, 14, 15 };
        var selectedn = from n in list1 where n % 2 != 0 orderby n.ToString() select n.ToString();
        Console.WriteLine("Впорядкування:");
        foreach (var v in selectedn)
        {
            Console.WriteLine(v);
        }

        Console.WriteLine("--------");
        var selectedc = from n in list1
                        where n % 2 != 0
                        orderby n.ToString()
                        select n.ToString();
        Console.WriteLine("Впорядкування:");
        foreach (var v in selectedc)
        {
            Console.WriteLine(v);
        }

        Console.WriteLine("-------");
        Console.WriteLine("За допомогою лямд:");
        var l = list1.Where(n => n % 2 != 0).OrderBy(n => n.ToString()).Select(n => n.ToString());

        Console.WriteLine("Впорядкування:");
        foreach (var str in l)
        {
            Console.WriteLine(str);
        }
    }
}