using System;

public class Departament
{
	List <Room> rooms = new List <Room> ();
	public string Name { get; set; }
	public Departament(string name)
	{
		Name = name;
	}
    public bool AddPatientToFirstAvailableRoom(Patient patient)
    {
		for (int i = 0; i < rooms.Count; i++)
		{
			if (rooms[i].IsFree())
			{
				rooms[i].AddPatient(patient);
				return true;
			}
		}
		return false;
    }

}


