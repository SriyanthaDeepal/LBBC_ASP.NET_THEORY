using System;

namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        // Create a UserAccount instance (represents a user with default values)
        private UserAccount user = new UserAccount { Username = "JohnDoe", Email = "john@example.com" };

        protected void Page_Load(object sender, EventArgs e)
        {
            // Subscribe to the AccountActivated event
            user.AccountActivated += User_AccountActivated;
        }

        // Button Click Event: Calls the ActivateAccount() method
        protected void btnActivate_Click(object sender, EventArgs e)
        {
            user.ActivateAccount(); // Activates the account and raises an event
        }

        // Event Handler: Executes when the AccountActivated event is triggered
        private void User_AccountActivated(object sender, EventArgs e)
        {
            lblMessage.Text = "Account Status: Active"; // Update label text
            lblMessage.ForeColor = System.Drawing.Color.Green; // Change text color to green
        }
    }
}
