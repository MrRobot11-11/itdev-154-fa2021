using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Console;


namespace Lantz_PatientList_Final_Project
{
    class Data
    {
        
        //Create two hashtable to store values
        Hashtable patientNameTable = new Hashtable();
        Hashtable patientDateofBirthTable = new Hashtable();
        
        

        //Add items to the inventory.  Key is auto-generated
        public void AddToPatientDB()
        {
            

            bool controlVar = true;
            int patientKey = 1;
            string secondChoice, patientName, patientDOB;


            do
            {   
                WriteLine("\nWhat is the patient's name that you would like to add?");
                patientName = ReadLine();
                WriteLine("\nWhat is the patient's date of birth?");
                patientDOB = ReadLine();

                

                //Add name and key to hashtable
                patientNameTable.Add(patientKey, patientName);

                //Add dob to 2nd hashtable
                patientDateofBirthTable.Add(patientKey, patientDOB);
                
                
                WriteLine("\nPatient Name: [{0}] \nDate of Birth: [{1}] \nPatient Key [{2}]", patientNameTable[patientKey], patientDateofBirthTable[patientKey], patientKey);

                WriteLine("\nWould you like to add another patient?");
                WriteLine("Enter [Y] to add, enter [N] to exit");

                secondChoice = ReadLine().ToUpper();



                if (secondChoice == "Y")
                {
                    controlVar = true;
                    patientKey++;
                }
                    
                else
                    controlVar = false;

            } while (controlVar);
            
            DisplayPatients();
        }

        //Search by key 
        public void SearchByKey(int itemKey)
        {
            if (patientNameTable.Contains(itemKey))
            {
                WriteLine("\nThe patient you are looking for is [{0}]", patientNameTable[itemKey].ToString());
            }
            else
            {
                WriteLine("The patient you are looking for doesn't exist");
            }
        }

        //Search by name
        public void SearchByName(string itemValue)
        {
            foreach (DictionaryEntry de in patientNameTable)
            {
                for (int i = 1; i < patientNameTable.Count +1 ; i++)
                {
                    if (Convert.ToString(de.Value) == itemValue)
                    {
                        WriteLine("\nThe patient you are searching for " +
                            "has a number of [{0}]", de.Key);
                        break;
                    }
                    else
                    {
                        WriteLine("Patient was not found in database.");
                    }
                }
            }
        }

        //Search by dob
        public void SearchByDOB(string itemValue)
        {
            foreach (DictionaryEntry de in patientDateofBirthTable)
            {
                for (int i = 0; i < patientDateofBirthTable.Count; i++)
                {
                    if (Convert.ToString(de.Value) == itemValue)
                    {
                        WriteLine("\nThe patient you are searching for " +
                            "has a number of [{0}]", de.Key);
                        break;
                    }
                    else
                    {
                        WriteLine("Patient was not found in database.");
                    }
                }
            }
        }

        //Delete an item from patient database
        public void DeleteFromDatabase(int itemNumber)
        {
            if (patientNameTable.Contains(itemNumber))
            {
                patientNameTable.Remove(itemNumber);
                patientDateofBirthTable.Remove(itemNumber);
            }
               
            else
                WriteLine("\nPatient does not exist in database");
        }

       
        
        public void DisplayPatients()
        {
            for (int i = 1; i < patientNameTable.Count + 1  ; i++)
            {
                WriteLine("Patient Name: [{0}] Patient DOB: [{1}]", 
                    patientNameTable[i], patientDateofBirthTable[i]);
                
            }
        }

     //Return an arraylist of hashtable keys
     public static ArrayList GetKeys(Hashtable table)
        {
            return (new ArrayList(table.Keys));
        }

    //Return an arraylist of hashtable values
    public static ArrayList GetValues(Hashtable table)
        {
            return (new ArrayList(table.Values));
        }

    //Show table in ascending order by keys
    public void SortByKeyAscending()
        {
            ArrayList keys = GetKeys(patientNameTable);

            //Sort the list
            keys.Sort();

            foreach (Object asc in keys )
            {
                WriteLine("Patient Number: {0} Patient Name: {1}", asc, patientNameTable[asc]);
            }

        }

        //Show table in ascending order by keys
        public void SortByKeyDescending()
        {
            ArrayList keys = GetKeys(patientNameTable);

            //Sort the list
            keys.Sort();

            //Reverse the sorted list
            keys.Reverse();

            foreach (Object desc in keys)
            {
                WriteLine("Patient Number: {0} Patient Name: {1}", desc, patientNameTable[desc]);
            }
        }

        //Show table in ascending order by name
        public void SortByNameAscending()
        {
            int[] arrayKey = new int[patientNameTable.Count];//Temp hashtable key
            string[] arrayValue = new string[patientNameTable.Count];//Temp hashtable value

            patientNameTable.Keys.CopyTo(arrayKey, 0);
            patientNameTable.Values.CopyTo(arrayValue, 0);

           Array.Sort(arrayValue, arrayKey); //Sort hashtable by value
          
            for (int i = 0; i < arrayKey.Length; i++)
            {
                WriteLine("Id number: [{0}] Patient name: [{1}]", arrayKey[i].ToString(), arrayValue[i].ToString());
            }
        }

        //Show table in descending order by name
        public void SortByNameDescending()
        {
            ArrayList nameValues = GetValues(patientNameTable);

            //Sort the list
            nameValues.Sort();

            //Reverse the sorted list
            nameValues.Reverse();

            for (int i = 0; i < nameValues.Count; i++)
            {
                WriteLine("Patient Name: {0}", nameValues[i]);
            }
        }
    }//End of class
}//End of namespace
