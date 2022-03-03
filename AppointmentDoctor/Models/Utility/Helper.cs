﻿ using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentDoctor.Models.Utility
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";
        public static string appointmentAdded = "Appointment added successfully";
        public static string appointmentUpdated = "Appointment updated successfully";
        public static string appointmentDeleted = "Appointment deleted successfully";
        public static string appointmentExist = "Appointment for select date and time already exists";
        public static string appointmentNotExists = "Appointment not exists";
        public static string meetingConfirm = "Meeting confirm successfully";
        public static string meetingConfirmError = "Error while confirming the meeting";
        public static string appointmentAddError = "Something went wrong Please try again";
        public static string appointmentUpdatError = "Something went wrong Please try again";
        public static string Somethingwentwrong = "Something went wrong Please try again";
        public static int success_code = 1;
        public static int failure_code = 0;
        public static List<SelectListItem> GetRoleForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value = Helper.Admin,Text = Helper.Admin},
                   new SelectListItem{Value = Helper.Patient,Text = Helper.Patient},
                      new SelectListItem{Value = Helper.Doctor,Text = Helper.Doctor}
            };
        }
        public static List<SelectListItem> GetTimeDropDown()
        {
            int minute = 60;
            List<SelectListItem> duration = new List<SelectListItem>();
            for (int i = 1; i <= 12; i++)
            {
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + "Hr" });
                minute = minute + 30;
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + "Hr 30 min" });
                minute = minute + 30;
               
            }
            return duration;
        }
    }
}
