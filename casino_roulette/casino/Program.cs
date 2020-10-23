using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("input your balance wallet: ");
    int balance=int.Parse(Console.ReadLine());
  
    while(balance!=0)
    {
      Console.WriteLine("input your bet: ");
      int bet=int.Parse(Console.ReadLine());
      help();
      switch(Console.ReadLine())
      {
        case "1":Console.WriteLine("Your current balance: "+ spin_number(balance, bet));
        break;
        case "2":Console.WriteLine("Your current balance: "+ spin_color(balance, bet));
        break;
        default: Console.WriteLine("Input  1 or 2 ");
        break;
      }
      balance-=bet;
      Console.WriteLine("You lost. Wanna make another bet.");
    }
    
    Console.WriteLine("You don't have money.");
    Console.ReadKey();
  }

  static void help()
  {
      Console.WriteLine("Choose an option(1 or 2):");
      Console.WriteLine("1) Number bet");
      Console.WriteLine("2) Color Bet");
  }

  static double? spin_number(double balance, double betAmount)
  {
    Random rnd=new Random();
    Console.WriteLine("iNPUT NUMBER from 1 to 36: ");
    int num_bet=int.Parse(Console.ReadLine());
    if((num_bet>=1) || (num_bet<=36))
    {
      int num_rand=rnd.Next(0,37);
      Console.WriteLine("It's number "+ num_rand);
      if(num_rand==num_bet)
      {
        balance+=betAmount*20;
        Console.WriteLine("Your bet x20");
      }
      else
      {
        balance-=betAmount;
        Console.WriteLine("You lost your money");
      }
    }
    else
    {
        Console.WriteLine("You wasn't choose Number");
    }
      
      
      return balance;
    
  }

  static double? spin_color(double balance, double betAmount)
  {
      Random rnd=new Random();
      
      string[] colors={"Red","Black"};

      Console.WriteLine("input color Red or Black: ");
      int color_bet=int.Parse(Console.ReadLine());
      if(color_bet==int.Parse("Black") || color_bet==int.Parse("Red"))
      {
         int color_rand=rnd.Next(colors.Length);
         Console.WriteLine("Roulette lands on" + color_rand);
         if(color_rand==color_bet)
         {
           balance+=betAmount*2;
           Console.WriteLine("Your bet x2");
         }
         else
         {
           Console.WriteLine("You have lost.");
         }
      }
       
      else
      {
        Console.WriteLine("You wasn't choose Number or Color");
      }
    
      return balance;
  }
}