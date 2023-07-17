using Sinav.Business.Abstract;
using Sinav.Core.Utilities.Result;
using Sinav.Core.Utilities.Security.Hashing;
using Sinav.Entities.Concrete;
using Sinav.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userSerivce;
        public AuthManager(IUserService userService)
        {
            _userSerivce = userService;
        }
        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userSerivce.GetByUserName(userForLoginDto.UserName,userForLoginDto.Password);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>("Kullanıcı bulunamadı");//hata mesajlarını oluştur tamam!!!!!!!!!! sonra controller
            }

            //if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password))
            //{
            //    return new ErrorDataResult<User>("Parola hatası");
            //}

            return new SuccessDataResult<User>(userToCheck, "Başarılı giriş");
        }
    }
}
