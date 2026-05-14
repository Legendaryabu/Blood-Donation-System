namespace BloodBankApp.Services
{
    /// <summary>
    /// A simple singleton service to store the currently logged-in user's name.
    /// </summary>
    public class CurrentUserService
    {
        public string? Username { get; set; }
    }
}
