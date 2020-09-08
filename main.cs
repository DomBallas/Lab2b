using System;

class MainClass {
  public static void Main (string[] args) {
Console.WriteLine("Enter a number");
int num1 = Convert.ToInt32
(Console.ReadLine());
Console.WriteLine("Enter another number");
int num2 = Convert.ToInt32
(Console.ReadLine());
int sum=num1+num2;
Console.WriteLine("sum="+ sum);

int diff=num2-num1;
Console.WriteLine("diff="+ diff);

int product=num2*num1;
Console.WriteLine("product="+ product);

int quotient=num2/num1;
Console.WriteLine("quotient="+ quotient);

int remainder=num2%num1;
Console.WriteLine("remainder="+ remainder);



}
}