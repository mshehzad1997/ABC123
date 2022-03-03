using AppointmentDoctor.Models.Utility;
using AppointmentDoctor.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentDoctor.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            this._appointmentService = appointmentService;
        }
        public IActionResult Index()
        {
            ViewBag.DoctorList = _appointmentService.GetDoctorLists();
            ViewBag.PatientList = _appointmentService.GePatientLists();
            ViewBag.Duration = Helper.GetTimeDropDown();
            return View();
        }
    }
}
