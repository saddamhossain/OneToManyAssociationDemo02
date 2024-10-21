Doctor doctor = new Doctor("Dr. Jane");
Patient patient1 = new Patient("Alice");
Patient patient2 = new Patient("Bob");

doctor.AddPatient(patient1);
doctor.AddPatient(patient2);

doctor.DiagnosePatient(patient1, "Cold");
doctor.PrescribeTreatment(patient1, "Rest and fluids");
doctor.ScheduleAppointment(patient1, DateTime.Now.AddDays(3));

doctor.DiagnosePatient(patient2, "Sprained Ankle");
doctor.PrescribeTreatment(patient2, "Rest and ice");
doctor.ScheduleAppointment(patient2, DateTime.Now.AddDays(7));

doctor.ShowPatientsInfo();