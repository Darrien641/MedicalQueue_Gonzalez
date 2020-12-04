using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalQueue_Gonzalez
{
    class Patient
    {
        public Patient(string name, int priority)
        {
            _name = name;
            _priority = priority;
        }
        private readonly string _name;
        private readonly int _priority;
        public string Name { get { return _name; } }
        public int Priority { get { return _priority; } }
        
    }
}
