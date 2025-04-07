using System;

public class UserAccount
{
    // Properties (Encapsulated Data)
    public string Username { get; set; } // Stores the username
    public string Email { get; set; }    // Stores the email
    public bool IsActive { get; private set; } // Indicates if the account is active

    // Event: Raised when the account is activated
    public event EventHandler AccountActivated;

    // Method: Activates the account and raises an event
    public void ActivateAccount()
    {
        IsActive = true; // Change account status to active
        AccountActivated?.Invoke(this, EventArgs.Empty); // Trigger event if there are subscribers
    }

    // Method: Deactivates the account (Not used in UI but could be useful)
    public void DeactivateAccount()
    {
        IsActive = false; // Change account status to inactive
    }
}
