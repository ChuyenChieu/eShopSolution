using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request); //Trả về trạng thái đăng nhập

        Task<bool> Register(RegisterRequest request); //Đăng kí

        Task<PagedResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request);
    }
}