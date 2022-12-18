namespace Mock_interview.Mock_interviewServiceTools
{
	public interface IUserService
	{
		ValueTask<UserForViewDTO> CreateAsync(UserForCreationDTO userForCreationDTO);

	}
}