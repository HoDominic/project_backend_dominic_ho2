namespace BookAPI.Controllers
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}