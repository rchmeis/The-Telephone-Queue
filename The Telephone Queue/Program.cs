namespace The_Telephone_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            
            Clinic clinic = new Clinic();
            clinic.Enqueue(new Patient("Jonas", "ondt i røven"));
            clinic.Enqueue(new Patient("Mona Lisa", "ked af sit mystiske smil"));
            clinic.Enqueue(new Patient("Kristina", "hovedpine"));

            Console.WriteLine("number of patients in queue: " + clinic.PatientsInQueue());

            while (clinic.PatientsInQueue() > 0)
            {
                Console.WriteLine(clinic.Dequeue()); //dequeue + visning af den person der fjernes fra køen.                
                Thread.Sleep(2000);
            }

            Console.WriteLine("There are no more patients in the queue.");
           
           
            
           
            
        }
    }
}
