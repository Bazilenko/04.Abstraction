using System;
using System.ComponentModel.Design;
class Program{
    static void Main()
    {
        string com = " ";
        Hospital hospital = new Hospital();
        while ((com = Console.ReadLine()) != "Outputs")
        {
            string[] info = com.Split();
            string depName = info[0];
            string docFName = info[1] + " " + info[2];
            string patName = info[3];
            hospital.AdmitPatient(depName, docFName, patName);
        }
        while ((com = Console.ReadLine()) != "End") {
            string[] info = com.Split();
            if (com.Length == 1)
            {
                hospital.PrintDepartmentPatients(info[0]);
            }
            else if (com.Length == 2) 
                {
                    hospital.PrintDepartmentPatients(info[1]);
                }
            else
            {

            }

            }
        }

    }