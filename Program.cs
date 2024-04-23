// See https://aka.ms/new-console-template for more information


using System;
using System.Runtime.InteropServices;
namespace CppBind
{
  class Program
  {
    [DllImport(@"./cpp/libhello-cpp.so")]
    public static extern void PrintHelloWorld();

    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World C#!");
      PrintHelloWorld();
    }
  }
}
