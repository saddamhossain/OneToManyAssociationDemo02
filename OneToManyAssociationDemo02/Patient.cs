namespace OneToManyAssociationDemo02;

public class Patient
{
    public string Name { get; private set; }
    public string Diagnosis { get; private set; }
    public string Treatment { get; private set; }
    public DateTime AppointmentDate { get; private set; }

    public Patient(string name)
    {
        Name = name;
    }

    public void SetDiagnosis(string diagnosis)
    {
        Diagnosis = diagnosis;
    }

    public void SetTreatment(string treatment)
    {
        Treatment = treatment;
    }

    public void ScheduleAppointment(DateTime date)
    {
        AppointmentDate = date;
    }

    public void ViewInfo()
    {
        Console.WriteLine($"Patient: {Name}, Diagnosis: {Diagnosis}, Treatment: {Treatment}, Appointment: {AppointmentDate.ToShortDateString()}");
    }
}
