using eshop.Entities;

namespace eshop.Application.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>()
        {
            new User(){ Id=1, UserName="turkay", Password="123", Role="Admin"},
            new User(){ Id=2, UserName="elmas", Password="123", Role="Editor"},
            new User(){ Id=3, UserName="alaattin", Password="123", Role="Client"},

        };

        public User ValidateUser(string userName, string password)
        {
            return _users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }
    }
}
