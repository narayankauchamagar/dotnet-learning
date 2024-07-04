// See https://aka.ms/new-console-template for more information

using learning_dotnet.Day1;

class Program {

    // public static void Main() {
    //     DataTypesCheck();
    //     StringInterpolationExample();
    //     StringManipulation();
    //     StringCompare();
    // }

    static void StringCompare() {
        string s1 = "hello";
        string s2 = new string("hello");
        string s3 = new string("hello");
        Console.WriteLine(s1.Equals(s2));
        Console.WriteLine(s1 == s2);
        Console.WriteLine(s2 == s3 );
    }
    
    static void StringInterpolationExample() {
        int a = 100;
        float b = 250.23f;
        string c = "CSharp";
        
        //String output the old way - using placehodler
        Console.WriteLine("The values are {0}, {1}, {2}", a, b, c);
        
        // Using String interpolation
        Console.WriteLine($"The values are {a}, {b}, {c}");
        
        //String interpolation can contain expressions
        Console.WriteLine($"(a + b) / b is {(a + b)/b}");

        float f1 = 123.4f;
        int i1 = 2000; 
        
        //Spacing and Alignments: Indexes
        Console.WriteLine("{0, -15} {1, 10}", "Float Value", "Int value");
        Console.WriteLine("{0, -15} {1, 10}", f1, i1);
        
        //Spacing and Alignments: Interpolation
        Console.WriteLine("{0, -15} {1, 10}", "Float Value", "Int value");
        Console.WriteLine($"{f1, -15} {i1, 10}");
    }

    static void StringManipulation() {
        string[] strs = ["one", "two", "three", "four"];
        
        string outstr;
        outstr = String.Concat(strs);
        Console.WriteLine(outstr);
        outstr = String.Join('.', strs);
        Console.WriteLine(outstr);
        outstr = String.Join("---", strs);
        Console.WriteLine(outstr);

    }

    static void DataTypesCheck() {
    
        //numbers
        byte a = 255;
        short b = 234;
        int c = 456231;
        // can be given default value with defalut keyword
        long d = default;
    
        Console.WriteLine($"byte: {a}, short: {b}, int: {c}, Long {d}");

        float e = 34.4545646546f;
        double f = 34.3465465465465456;
        decimal g = 34.546546542165465465465456m;
    
        //using ? makes variable nullable 
        short? count = 234;
        count = null;
    
    
        // Creating object

        int[] ages = [23, 15, 8, 9, 65];
        Person person = new Person("Ram");

        Person person2 = new("Ram");
        Console.WriteLine(person == person2);
        Console.WriteLine(person.Equals(person2));
    }
}


