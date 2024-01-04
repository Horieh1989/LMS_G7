using LMS_G7.Shared;
using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Pages
{
    public partial class Activity
    {
        private bool showActivityItems = false;
        private ActivityModel newActivity = new ActivityModel();

        private bool elearnitems = false;

        private bool showActivity = true;

        private bool showPopup = false;
        private void showelearn()
        {
            elearnitems = true;
        }

        private void ShowActivity()
        {
            showActivityItems = true;
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
        }

        private void HandlePopupVisibilityChange(bool isVisible)
        {
            showPopup = isVisible;
            StateHasChanged(); // Update the UI
        }

    }
   
}
