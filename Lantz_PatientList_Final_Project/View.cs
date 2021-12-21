using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace Lantz_PatientList_Final_Project
{
    class View
    {

        public int GetMenuChoice()
        {
            int choice;

            WriteLine("\n********Patient Database***********");
            WriteLine("\n1. Add a patient to the system");
            WriteLine("2. Delete a patient from the system by Id ");
            WriteLine("3. Search for a patient by Id Number");
            WriteLine("4. Search for a patient by name to get Id");
            WriteLine("5. Display all patients in database");
            WriteLine("6. Display all patients by Id # in ascending order");
            WriteLine("7. Display all patients by Id # in descending order");
            WriteLine("8. Display all patients by Name in ascending order");
            WriteLine("9. Display all patients by Name in ascending order");
            WriteLine("10. Exit the system");

            choice = Convert.ToInt32(ReadLine());


            return choice;
        }




















    }
}
