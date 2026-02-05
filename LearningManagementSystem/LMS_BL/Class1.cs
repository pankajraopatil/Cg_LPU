namespace LMS_BL
{
    public class UserService
    {
        public bool ValidateUser(string username, string password)
        {
            // Basic validation logic
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            
            // Add more validation logic here
            return username.Length >= 3 && password.Length >= 6;
        }

        public string GenerateUserToken(string username)
        {
            // Simple token generation for demo
            return $"TOKEN_{username}_{DateTime.Now.Ticks}";
        }

        public bool IsValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".");
        }
    }
}
