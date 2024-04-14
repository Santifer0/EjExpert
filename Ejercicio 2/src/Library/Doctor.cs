using System;


namespace Program
{
    public class Doctor
    {
        public string Id {get; set; }
        public string Name {get; set; }
        public string PhoneNumber {get; set; }
        public string  Age {get; set; }

        public string Specialty {get; set; }

        public Doctor(string Id, string Name, string PhoneNumber, string Age)
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