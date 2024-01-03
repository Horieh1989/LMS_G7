using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace LMS_G7.Client.Pages
{
    public partial class Popup
    {
        [Parameter] public bool IsVisible { get; set; }
        [Parameter] public EventCallback<bool> IsVisibleChanged { get; set; }

        private string EnteredText { get; set; }

        private string selectedFileName;

        private void ClosePopup()
        {
            IsVisible = false;
            IsVisibleChanged.InvokeAsync(IsVisible);
        }

        private void SubmitForm()
        {
            // Handle form submission logic here
            // For now, displaying an alert with the entered text
            ClosePopup(); // Close the popup after submission

        }

        private void CancelForm()
        {
            ClosePopup();
        }

        private async Task HandleFileSelected(InputFileChangeEventArgs e)
        {
            var file = e.File;

            if (file != null)
            {
                selectedFileName = file.Name;

                // You can perform further actions with the file, such as uploading it to a server.
                // For demonstration purposes, let's just print some information about the file.
                Console.WriteLine($"File Name: {file.Name}");
                Console.WriteLine($"File Size: {file.Size} bytes");
            }
        }
    }
}
