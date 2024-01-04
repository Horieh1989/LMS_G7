using LMS_G7.Shared;

namespace LMS_G7.Client.Pages
{
    public partial class Activity
    {
        private bool showActivityItems = false;
        private ActivityModel newActivity = new ActivityModel();

        private bool elearnitems = false;
        private bool lectureitems = false;

        private bool showActivity = true;

        private bool showPopup = false;
        private bool practiceitems = false;
        private bool assignitems = false;
        private void showelearn()
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

        private void AddActivity()
        {
            // await ActivityController.AddActivity(newActivity);
            // Add logic to save the newActivity to your local database or perform any other desired actions.
            // For simplicity, let's just print the details for now.
            Console.WriteLine($"New Activity Added: {newActivity.Name}, {newActivity.ActivityType}, {newActivity.Description}, {newActivity.StartDate}, {newActivity.EndDate}");

            // Reset the form and hide the input fields
            newActivity = new ActivityModel();
            showActivityItems = false;
        }       
        private void OpenPopup()
        {
            showPopup = true;
            showActivityItems = false;
            elearnitems = false;
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
