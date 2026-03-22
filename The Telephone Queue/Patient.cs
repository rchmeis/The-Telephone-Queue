using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace The_Telephone_Queue
{
    internal class Patient
    {
        private string _name;
        private string _need;
        private DateTime _contactTime;

        public Patient(string name, string need)
        {
            Name = name;
            Need = need;
            ContactTime = DateTime.Now;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Need
        {
            get { return _need; }
            set { _need = value; }
        }
        public DateTime ContactTime
        {
            get { return _contactTime; }
            set { _contactTime = value; }
        }
        public override string ToString()
        {
            return $"{_name}, {_need}, {_contactTime}";
        }

    }
}
