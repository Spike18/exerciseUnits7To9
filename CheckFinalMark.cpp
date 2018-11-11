//Jaime Francisco Rebollo Domínguez
/*
 * A program that calculates the average of 3 marks entered by the user,
 * and shows the average if all the marks are equal or greater than 4 and 
 * the average is greater than 5. 
 * 
 */

#include <iostream>
using namespace std;

int main()
{
    int mark1, mark2, mark3;
    int average;
    
    cout << "Enter the 3 marks: ";
    cin >> mark1 >> mark2 >> mark3;
    
    average = (mark1 + mark2 + mark3) / 3;
    
    cout << "The final mark is: ";
    if((mark1 >= 4 && mark2 >= 4 && mark3 >= 4 && average >= 5) || 
        (average < 5))
    {
        cout << average << endl;
    } else if(mark1 >= 4 && mark2 >= 4 && mark3 >= 4 && average < 5)
    {
        cout << "4" << endl;
    } else
    {
        cout << "3" << endl;
    }
}
