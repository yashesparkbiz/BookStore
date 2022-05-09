namespace BookStore1.Data.Service
{
    public interface IUserService
    {
        string GetUserId();
        bool IsAuthenticated();
    }
}