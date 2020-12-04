using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalQueue_Gonzalez
{
    class ERQueue
    {
        public List<Patient> Patients = new List<Patient>(13);

        public string Menu()
        {
            return "(A)dd Patient (P)rocess Current Patient (L)ist All in Queue (Q)uit";
        }
        public int Enqueue(string name, int priority)
        {
            Patient p = new Patient(name, priority);
            // returns number of patients after adding or returns -1 if error
            if (p != null)
            {
                Patients.Add(p);
                return Patients.Count;
            }
            return -1;
        }

        public string Dequeue()
        {// returns queue item that should be shown too the user
            Patient CurrentPatient = Patients[0];
            if (CurrentPatient == null)
            {
                return null;
            }
            Patients.RemoveAt(0);
            return $"{CurrentPatient.Name}  {CurrentPatient.Priority}";
        }

        public override string ToString()
        {
            string PatientList = "";
            if (Patients.Count <= 0)
            {
                return "The list is empty!";
            }
            foreach (Patient p in Patients)
            {

                PatientList += p.Name+"\t"+p.Priority+"\n";
            }
            return PatientList;

        }
    }
}
