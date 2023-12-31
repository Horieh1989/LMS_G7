﻿using LMS_G7.Shared;
using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Pages
{
    public partial class ActivityLst
    {
        private bool showActivityItems = false;
        private LMS_G7.Shared.Domain.Activity newActivity = new LMS_G7.Shared.Domain.Activity();

        public bool elearnitems = false;
        public bool lectureitems = false;

        public bool showActivity = true;

        public bool showPopup = false;
        public bool practiceitems = false;
        public bool assignitems = false;
        public void showelearn()
        {
            elearnitems = true;
            showActivityItems = false;
            lectureitems = false;
            practiceitems = false;
            assignitems = false;
        }
        private void showLecture()
        {
            lectureitems = true;
            elearnitems = false;
            showActivityItems = false;
            practiceitems = false;
            assignitems = false;
        }
        private void showSession()
        {
            practiceitems = true;
            lectureitems = false;
            elearnitems = false;
            assignitems = false;
            showActivityItems = false;
        }
        private void showAssign()
        {
            assignitems = true;
            practiceitems = false;
            lectureitems = false;
            elearnitems = false;
            showActivityItems = false;
        }

        private void ShowActivity()
        {
            showActivityItems = true;
            elearnitems = false;
            lectureitems = false;
            practiceitems = false;
            assignitems = false;
        }

        public void AddActivity()
        {
            // await ActivityController.AddActivity(newActivity);
            // Add logic to save the newActivity to your local database or perform any other desired actions.
            // For simplicity, let's just print the details for now.
            newActivity = new Activity();
            Console.WriteLine($"New Activity Added: {newActivity.Name}, {newActivity.ActivityType}, {newActivity.Description}, {newActivity.StartDate}, {newActivity.EndDate}");

            // Reset the form and hide the input fields
            newActivity = new Activity();
            showActivityItems = false;
        }
        private void OpenPopup()
        {
            showPopup = true;
            showActivityItems = false;
            elearnitems = true;
            lectureitems = false;
            practiceitems = false;
            assignitems = false;
        }

        private void HandlePopupVisibilityChange(bool isVisible)
        {
            showPopup = isVisible;
            StateHasChanged(); // Update the UI
        }

    }

}
