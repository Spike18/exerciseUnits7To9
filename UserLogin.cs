//Jaime Francisco Rebollo Domínguez

using System;

public class UserLogin
{
    public static void Main()
    {
        string u, p;
        byte times = 0;
        bool cL = false;
        
        do
        {
            times++;
            
            Console.Write("Enter your user: ");
            u = Console.ReadLine();
            Console.Write("Enter your password: ");
            p = Console.ReadLine();
            
            if((u != "Jhin" || p != "4444") && (times < 3))
            {
                Console.WriteLine("Incorrect login, try again.");
            } else if(u == "Jhin" && p == "4444")
            {
                cL = true;
            }
            
            Console.WriteLine();
        }while(!cL && times < 3);
        
        if(cL)
        {
            Console.WriteLine("Acces granted! Welcome Jhin.");
        } else
        {
            Console.WriteLine(
                "Acces denied! Try again in a few minutes.");
        }
    }
}
