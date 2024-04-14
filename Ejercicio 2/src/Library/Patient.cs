using System;

namespace Program
{
    public class Patient
    {
        public string Id {get; set; }
        public string Name {get; set; }
        public string PhoneNumber {get; set; }
        public string  Age {get; set; }

        public Patient(string Id, string Name, string PhoneNumber, string Age)
        {
            if (string.IsNullOrEmpty(Id) ||string.IsNullOrEmpty(Name)||string.IsNullOrEmpty(PhoneNumber)|| string.IsNullOrEmpty(Age))
            {
            }
            else
            {
            this.Id = Id;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Age = Age;
            }
        }

    }

}
