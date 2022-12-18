using Mock_interview.DTOs;
using Mock_interview.Entities;
using System.Linq.Expressions;

namespace Mock_interview.Mock_interviewServiceTools
{
	public interface IUserService
	{
        Task<User> ExistAsync(int id);
        Task<User> GetAsync(int UserId);
        Task<List<User>> GetAllAsync();
        Task<(bool IsSuccess, Exception Exception, User User)> CreateAsync(User user);
        Task<(bool IsSuccess, Exception Exception)> UpdateAsync(User user);
        Task<(bool IsSuccess, Exception Exception)> DeletAsync(int id);
    }
}