using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lantz_PatientList_Final_Project
{
    class Controller
    {
        public void RunProgram()
        {
            View vw = new View();
            Data patientData = new Data();
            


            int choice;

            while (true)
            {
                choice = vw.GetMenuChoice();

                if (choice == 12)
                    break;

                switch (choice)
                {
                    case 1:  //Add an item to the system
                        patientData.AddToPatientDB();
                        break;

                    case 2: //Delete an item from the system by Id
                        WriteLine("What patient number would you like to delete?");
                        var data = Convert.ToInt32(ReadLine());
                        patientData.DeleteFromDatabase(data);
                        patientData.DisplayPatients();
                        break;

                    case 3: //Search for item by id number
                        WriteLine("\nWhat is the patient number you are looking for?");
                        var itemKey = Convert.ToInt32(ReadLine());
                        patientData.SearchByKey(itemKey);
                        break;

                    case 4://Search by item to get key
                        WriteLine("\nWhich patient would you like to search for?");
                        var itemValue = ReadLine();
                        patientData.SearchByName(itemValue);
                        break;

                    case 5: //Display all items in inventory
                        patientData.DisplayPatients();
                        break;

                    case 6: //Display sorted names by key ascending
                        patientData.SortByKeyAscending();
                        break;

                    case 7: //Display sorted names by key ascending
                        patientData.SortByKeyDescending();
                        break;

                    case 8: //Display sorted names by name ascending
                        patientData.SortByNameAscending();
                        break;

                    case 9: //Display sorted names by name descending
                        patientData.SortByNameDescending();
                        break;

                    case 10: //Exit the system
                        break;

                    default:
                        break;
                }
            }
        }
    
    
    
    
    }//End of class
}//End of namespace
