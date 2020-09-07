using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
  public  class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("1) Insert money");
            Console.WriteLine("2) Withdraw money");
            Console.WriteLine("3) Exit");
            Console.SetCursorPosition(0, 8);
            Console.Write("Please choose a number from above: ");
        }
    }
}
