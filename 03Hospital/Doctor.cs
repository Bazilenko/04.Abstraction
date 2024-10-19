using System;

public class Doctor
{
	public string FName { get; set; }
	public string LName { get; set; }
	public List<Patient> Patients { get; set; }
	public Doctor(string fname, string lname)
	{
		FName = fname;
		LName = lname;
		Patients = new List<Patient>();
	}
	public void AddPatient(Patient patient)
	{
		Patients.Add(patient);
	}
}
