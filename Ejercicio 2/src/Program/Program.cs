using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("1","Santiago","099196294","18");
            Doctor doctor1 = new Doctor("1","Matias","098682512","42");
            Appointment appointment1 = new Appointment("1",patient1.Id,doctor1.Id,"19:30","14/4/2024","Lagomar");
            Console.WriteLine(appointment1.SetAppointment());
        }
    }
}
