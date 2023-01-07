using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    delegate void Delegate(string s);
    internal class Hospital
    {
        private List<Patient>patients = new List<Patient>();

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }
        public void RemovePatient(Patient patient) 
        {
            patients.Remove(patient);
        }
        public void ChangeDiagnosis(Patient patient, string diagnosis)
        {
            foreach(Patient pat in patients)
            {
                if (patient == pat)
                {
                    pat.SetDiagnosis(diagnosis);
                }
            }
        }
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();   
            foreach (Patient pat in patients) 
            {
                stringBuilder.AppendLine(pat.GetPatientInfo());
            }
            return stringBuilder.ToString();
        }
    }
}
