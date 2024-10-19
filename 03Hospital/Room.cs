using System;

    public class Room
    {
        List<Patient> beds {  get; set; }
        public bool IsFree()
        {
            if (beds.Count > 3)
                return false;
            else 
                return true;
        }
        public Room()
        {
            beds = new List<Patient>(3);
        }
        public void AddPatient(Patient patient)
        {
            if(IsFree())
            beds.Add(patient);
        }
    }
