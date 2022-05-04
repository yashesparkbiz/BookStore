namespace BookStore1.Service
{
    public interface IUserService
    {
        string GetUserId();
        bool IsAuthenticated();
    }
}