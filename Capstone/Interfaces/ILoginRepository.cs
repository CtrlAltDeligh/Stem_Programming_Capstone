namespace Capstone.Interfaces;
using Capstone.Models;
public interface ILoginRepository
{
    Task<UserInfo> Login(string username, string password);    
}