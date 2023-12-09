{
    Console.WriteLine("1.Add\n2.Sub\n3.Mul\n4.Div\n5.Exit\n");
    Console.WriteLine("Press a key");
    var key = Console.ReadLine();

    Console.WriteLine("Press number a");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Press number b");
    var b = Convert.ToInt32(Console.ReadLine());

    var math = new Calculator.Math();

    try
    {
        switch (key)
        {
            case "1":
                Console.WriteLine($"Result = {math.Add(a, b)}");
                break;
            case "2":
                Console.WriteLine($"Result = {math.Sub(a, b)}");
                break;
            case "3":
                Console.WriteLine($"Result = {math.Mul(a, b)}");
                break;
            case "4":
                Console.WriteLine($"Result = {math.Div(a, b)}");
                break;
            case "5":
                return;

            default: Console.WriteLine("Unknown key"); break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}