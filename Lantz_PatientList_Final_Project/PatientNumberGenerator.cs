using System;
using System.Collections.Generic;
using System.Text;

namespace Lantz_PatientList_Final_Project
{
    class PatientNumberGenerator
    {
        Random rnd = new Random();

        //Creates random number to be used as Patient number
        public int NewPatientNum()
        {
            int newPatient = rnd.Next(100, 999);

            return newPatient;
        }








    }//End of class
}//End of NameSpace
