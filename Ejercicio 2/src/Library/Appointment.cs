using System;

namespace Program
{
    public class Appointment
    {
        private string AppointmentId;
        private string PatientId;
        private string DoctorId;
        private string DateTime;
        private string DateDay;
        private string DatePlace;
        
        public Appointment(string AppointmentId , string PatientId, string DoctorId,string DateTime,string DateDay, string DatePlace)
        {
            if (string.IsNullOrEmpty(AppointmentId) ||string.IsNullOrEmpty(PatientId)||string.IsNullOrEmpty(DoctorId)|| string.IsNullOrEmpty(DateTime)||string.IsNullOrEmpty(DateDay)|| string.IsNullOrEmpty(DatePlace))
            {
            }
            else
            {
            this.AppointmentId = AppointmentId;
            this.PatientId = PatientId;
            this.DoctorId = DoctorId;
            this.DateTime = DateTime;
            this.DateDay = DateDay;
            this.DatePlace = DatePlace;
            }
        }
    
        public string SetAppointment()
        {
            
            if (string.IsNullOrEmpty(AppointmentId) ||string.IsNullOrEmpty(PatientId)||string.IsNullOrEmpty(DoctorId)|| string.IsNullOrEmpty(DateTime)||string.IsNullOrEmpty(DateDay)|| string.IsNullOrEmpty(DatePlace))
            {
            return  "0";
            }
            else
            {
                return AppointmentId+"-"+PatientId+"-"+DoctorId+"-"+DateTime+"-"+DateDay+"-"+DatePlace;

            }
        }
    }
}
