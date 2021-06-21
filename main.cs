using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of the item");
    string item = Console.ReadLine();
    Console.WriteLine ("Enter the quantity of the item");
    double quantity = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Enter the price of the item");
    double price = Convert.ToDouble(Console.ReadLine());
    double total = quantity * price;
    Console.WriteLine ("Total price of the " + item + "(s) is " + total);
  }
}