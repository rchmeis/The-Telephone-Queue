using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace The_Telephone_Queue
{
    internal class Clinic
    {
        private Queue<Patient> queue;
        
        public Clinic()
        {
            queue = new Queue<Patient>();
        }
               
        public void Enqueue(Patient patient)
        {
            queue.Enqueue(patient);
            Console.WriteLine($"{patient} has been added to the queue");
        }

        public Patient Dequeue()
        {
            if (queue.Count > 0)
            {
                return queue.Dequeue();
                
            }
            else
            {
                Console.WriteLine("The queue is empty");
                return null;
            }
                     
        }

        public int PatientsInQueue()
        {
            int counter = queue.Count();
            return counter;
        }

        public Patient Peek()
        {
            if (queue.Count() > 0)
            {
                return queue.Peek();
            }
            else { return null; }
        }

    }
}
