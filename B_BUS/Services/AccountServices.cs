using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class AccountServices // Services thực hiện các tương tác trên account
    {
        // Khai báo Repository
        AccountRepository _repo;
        public AccountServices()
        {
            _repo = new AccountRepository();
        }
        public bool Login(string username, string password)
        {
            var account = _repo.GetAccount(username, password); // Lấy dữ liệu đăng nhập và kiểm tra
            if (account == null) // Không tìm thấy
            {
                return false;
            }
            else return true;

        }
        public string ForgetPassword(string username)
        {
            if (_repo.UpdateAccount(username))
            {
                var newAccount = _repo.GetAccountByUsername(username);
                return "Mật khẩu mới của bạn là: " + newAccount.Password;
            }
            else return "Sửa mật khẩu thất bại";

        }
    }
}
