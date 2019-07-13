# LibraryCalc03
Biblioteca para operações aritméticas


[![Build status](https://ci.appveyor.com/api/projects/status/ch34pnefw22yt1km/branch/master?svg=true)](https://ci.appveyor.com/project/jeh-dias/librarycalc03/branch/master)

##  How to install
Install-Package LibraryCalc03 -Version 1.0.1

## How to use
```cs
namespace Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var point = new PointTest(2, 2);
            var operation = new Operation();
            var result = operation.sum(45,77,-7);
            Console.WriteLine("result " + result);
        }
    }
}
```

![Nuget](https://img.shields.io/nuget/dt/LibraryCalc03.svg)
