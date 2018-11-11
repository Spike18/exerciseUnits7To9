//Jaime Francisco Rebollo Domínguez

#include <iostream>
using namespace std;

int main()
{
    int m1, m2, m3;
    int result;
    
    cout << "Enter the 3 marks: ";
    cin >> m1 >> m2 >> m3;
    
    // We calculate the average of the marks
    result = (m1 + m2 + m3) / 3;
    
    cout << "The final mark is: ";
    if((m1 >= 4 && m2 >= 4 && m3 >= 4 && result >= 5) || 
        (result < 5))
    {
        cout << result << endl;
    } else if(m1 >= 4 && m2 >= 4 && m3 >= 4 && result < 5)
    {
        cout << "4" << endl;
    } else
    {
        cout << "3" << endl;
    } //..if
}
