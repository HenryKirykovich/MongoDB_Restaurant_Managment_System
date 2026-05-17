using MongoDB_Restaurant_Management_System.Models;

namespace MongoDB_Restaurant_Management_System
{
    public static class Session
    {
        public static User CurrentUser { get; set; }

        public static bool IsLoggedIn => CurrentUser != null;
    }
}
