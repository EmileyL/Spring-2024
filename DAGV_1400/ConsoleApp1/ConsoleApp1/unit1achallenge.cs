using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //get a username
      Console.WriteLine("Please input a user name:");
      string username = Console.ReadLine();
      
      //get one number
      Console.WriteLine("Please input the first number:");
      int firstInput = Convert.ToInt32(Console.ReadLine());
      
      //get a second number
      Console.WriteLine("Please input the second number:");
      int secondInput = Convert.ToInt32(Console.ReadLine());

      //display them added
      Console.WriteLine("Them added: " + (firstInput+secondInput));

      //display them subtracted
      Console.WriteLine("Them subtracted: " + (firstInput-secondInput));

      //thank the user
      Console.WriteLine("Thank you " + username);
    }
  }
}

      