using A_DAL.Models1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class AccountRepository
    {
        // Khai Báo DBContext để có thể dử dụng được DBset mình cần
        SOF205_DemoContext _demoContext = new SOF205_DemoContext(); // Khởi tạo sẵn nếu sợ quên
        // Khai báo constructor
        public AccountRepository()
        {
            _demoContext = new SOF205_DemoContext(); // Khởi tạo context (ưu tiên)
        }
        //Chứa các phương thức
        public List<Account> GetAllAccount()
        {
            return _demoContext.Accounts.ToList(); // trỏ tới DBset Account
            // Phương thức ToList cho phép chúng ta chuyển Toàn bộ dữ liệu thành 1 List
        }
        public Account GetAccount(string username, string password) // Các giá trị này sẽ được truyền vào
        {
            //return _demoContext.Accounts.Find(id); // phương thức này cho phép tìm kiếm đối tượng
            //// trong bảng thông qua khóa chính
            return _demoContext.Accounts.FirstOrDefault(p => p.Username == username && p.Password == password);
            // Phương thức này cho phép chúng ta trả về đối tượng đầu tiên trong Bảng của CSDL thỏa mãn
            // điều kiện ta đặt trong ngoặc
        }
        public Account GetAccountByUsername(string username)
        {
            return _demoContext.Accounts.FirstOrDefault(p => p.Username == username);
        }
        public bool UpdateAccount(string username)
        {
            var account = GetAccountByUsername(username);
            if (account == null)
            {
                return false;
            }
            else
            {
                // Tạo mật khẩu mới có 6 kí tự
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var random = new Random();
                string newPassword = new string(Enumerable.Repeat(chars, 6)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                account.Password = newPassword;
                _demoContext.Accounts.Update(account);
                _demoContext.SaveChanges(); // Lưu lại những thay đổi
                return true;
            }
        }
    }
}
