using AppointmentDoctor.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentDoctor.Services
{
   public interface IAppointmentService
    {
        public List<DoctorVM> GetDoctorLists();
        public List<PatientVM> GePatientLists();
        public Task<int> AddUpdate(AppointmentVM model);
        public List<AppointmentVM> DoctorsEventsById(string doctorId);
        public List<AppointmentVM> PatientsEventsById(string patientId);
        public AppointmentVM GetById(int id);
        public Task<int> Delete(int id);
        public Task<int> ConfirmEvent(int id);
    }
}
