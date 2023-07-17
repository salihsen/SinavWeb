using Sinav.Core.Utilities.Result;
using Sinav.Entities.Concrete;
using Sinav.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        //IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
