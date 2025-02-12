namespace QueuingSystem.WebUI.WebForms.Infrastructure.ApiServices
{
    public class ApiConfig
    {
        public string GetQueuing() => $"https://localhost:5000/gateway/queuing/test";
        public string GetTicketsInProgressForTodayService() => $"https://localhost:5000/gateway/queuing/inprogress-for-today-service";
    }
}