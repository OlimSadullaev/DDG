using Microsoft.EntityFrameworkCore;
using Mock_interview.Data;
using Mock_interview.DTOs;
using Mock_interview.Entities;
using Mock_interview.Mock_interviewServiceTools;

namespace Mock_interview.Mock_InterviewServiceTools
{
	public class UserService : IUserService
	{
		private readonly MockDbContext _context;
        private readonly ILogger<UserService> _logger;

		public UserService(MockDbContext context, ILogger<UserService> logger)
		{
			_context = context;
			_logger = logger;
		}

        public async Task<(bool IsSuccess, Exception Exception, User User)> CreateAsync(User user)
		{
			try
			{
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"User {user.UserId} created successfully");
                return (true, null, user);
            }
			catch(Exception e)
			{
				_logger.LogInformation($"User failed");
				return (false, e, user);
			}
			
		}


		public async Task<(bool IsSuccess, Exception Exception)> DeletAsync(int id)
		{
			var user = await GetAsync(id);
			if(user == default(User))
			{
				return (false, new Exception("Not Found"));
			}

			try
			{
				_context.Users.Remove(user);
				await _context.SaveChangesAsync();

				_logger.LogInformation($"Successfully added id:{user.UserId}");
				return (true, null);
			}
			catch(Exception e)
			{
				_logger.LogInformation("Deleted User failed");
				return (false, null);
			}
		}

		public Task<User> ExistAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ExistsAsync(int id)
			=> _context.Users.AnyAsync(a => a.UserId == id);

        public Task<List<User>> GetAllAsync()
            => _context.Users.ToListAsync();

        public Task<User> GetAsync(int id)
            => _context.Users.FirstOrDefaultAsync(a => a.UserId == id);

        public async Task<(bool IsSuccess, Exception Exception)> UpdateAsync(User user)
		{
			if(!await ExistsAsync(user.UserId))
			{
				return (false, new Exception("Not found"));
			}
			try
			{
				_context.Users.Update(user);
				await _context.SaveChangesAsync();

				_logger.LogInformation($"Saved Successfully with ID: {user.UserId}");
				return(true, null);
			}
			catch
			{
				_logger.LogInformation("Updating actor failed");
				return(false, null);
			}
		}
	}
}