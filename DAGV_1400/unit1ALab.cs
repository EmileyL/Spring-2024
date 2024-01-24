using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    //ints are integers, they store whole numbers
    int myInt1 = 10;
    int myInt2 = 20;

    //float are a way to store numbers with decimals
    float myFloat1 = 1.2F;
    float myFloat2 = 23.5F;

    //strings are a way to store a collection of characters
    string mySting = "This is a string.";

    //booleans store either true or false
    bool myBoolean = true;

    //the expected result of this addition operator is 30
    Console.WriteLine(myInt1 + myInt2);

    //The expected result is false because 1.2 is not greater than 23.5
    Console.WriteLine(myFloat1 > myFloat2);

    //The result should be true as I used a logical or which means one
    //of them have to be true to return true
    Console.WriteLine(2 > 5 || myBoolean);
     }
  }
}