using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using UserManagement.Models;
namespace UserManagement.Data
{
    public class UserService
    {

        private readonly UserContext _userContext;

        public UserService(UserContext userContext)
        {
            _userContext = userContext;
        }

        public async Task<List<GetAllUsersResult>> GetAllUsersAsync()
        {
            return await _userContext.Procedures.GetAllUsersAsync();
        }


    }
}
