using System;

public class program
{
    public static void Main(string[] args)
    {
        double radius = 1.5; // radien av cirkeln
        double area = cirkelnsarea(radius); // använder metoden cirkelnsarea där radien är en parameter och resultatet har variabeln area
        Console.WriteLine("Cirkelns area är" + area);    
    }
    public static double cirkelnsarea(double radius)  // metod som räknar ut cirkelns area med hjälp av radius
    {
        return Math.PI * radius * radius;  // ger tilbaks arean av cirkeln i konsolen
    }


}