using System;

public class Hospital
{
    public Dictionary<string, Departament> Departments { get; set; }
    public Dictionary<string, Doctor> Doctors { get; set; }

    public Hospital()
    {
        Departments = new Dictionary<string, Departament>();
        Doctors = new Dictionary<string, Doctor>();
    }
    public void PrintDepartmentPatients(string departmentName)
    {
        if (Departments.ContainsKey(departmentName))
        {         
                Console.WriteLine(departmentName);            
        }
    }
    public void PrintDoctorPatients(string doctorFName)
    {
        if (Doctors.ContainsKey(doctorFName))
        {
                Console.WriteLine(doctorFName);
            
        }


    }
    public void AdmitPatient(string departmentName, string doctorFullName, string patientName)
    {
        if (!Departments.ContainsKey(departmentName))
        {
            Departments[departmentName] = new Departament(departmentName);
        }

        if (!Doctors.ContainsKey(doctorFullName))
        {
            string[] nameParts = doctorFullName.Split();
            Doctors[doctorFullName] = new Doctor(nameParts[0], nameParts[1]);
        }

        Patient patient = new Patient(patientName);
        if (Departments[departmentName].AddPatientToFirstAvailableRoom(patient))
        {
            Doctors[doctorFullName].AddPatient(patient);
        }
        else
        {
            Console.WriteLine("Patient is in other departament.");
        }
    }

   
    

    
    
}
