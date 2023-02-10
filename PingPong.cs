using System;
using System.Collections.Generic;

class PingPong{
    static void Main(){
        // after our Main entrypoint, we now move on to writing our Ping Pong Application

        Console.WriteLine("Hello My Beautiful User, Welcome to the Dynasty's PING PONG Tournament");
        Console.WriteLine("Please Enter any Number of your Choice");

        // saving user's number and turning it into an double; a double can account for oth integer and decimal numbers

        string userNumberInString = Console.ReadLine();

        double userNumber = double.Parse(userNumberInString);


        
    }
}