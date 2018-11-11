//Jaime Francisco Rebollo Domínguez
/*
 * A simple login program that asks the user his user and password, and
 * it blocks when the user reaches three attempts, or grants access if 
 * they're correct.
 *  
 */
using System;

public class UserLogin
{
    public static void Main()
    {
        string user, password;
        byte times = 0;
        bool correctLogin = false;
        
        do
        {
            times++;
            
            Console.Write("Enter your user: ");
            user = Console.ReadLine();
            Console.Write("Enter your password: ");
            password = Console.ReadLine();
            
            if((user != "Jhin" || password != "4444") && (times < 3))
            {
                Console.WriteLine("Incorrect login, try again.");
            } else if(user == "Jhin" && password == "4444")
            {
                correctLogin = true;
            }
            
            Console.WriteLine();
        }while(!correctLogin && times < 3);
        
        if(correctLogin)
        {
            Console.WriteLine("Acces granted! Welcome Jhin.");
        } else
        {
            Console.WriteLine(
                "Acces denied! Try again in a few minutes.");
        }
    }
}
