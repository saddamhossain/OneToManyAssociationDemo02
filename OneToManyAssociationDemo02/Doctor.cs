namespace OneToManyAssociationDemo02;

public class Doctor
{
    public string Name { get; private set; }

    private List<Patient> patients = new List<Patient>();

    public Doctor(string name)
    {
        Name = name;
    }

    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
    }

    public void DiagnosePatient(Patient patient, string diagnosis)
    {
        patient.SetDiagnosis(diagnosis);
    }

    public void PrescribeTreatment(Patient patient, string treatment)
    {
        patient.SetTreatment(treatment);
    }

    public void ScheduleAppointment(Patient patient, DateTime date)
    {
        patient.ScheduleAppointment(date);
    }

    public void ShowPatientsInfo()
    {
        Console.WriteLine($"Doctor {Name}'s Patients:");
        foreach (var patient in patients)
        {
            patient.ViewInfo();
        }
    }
}