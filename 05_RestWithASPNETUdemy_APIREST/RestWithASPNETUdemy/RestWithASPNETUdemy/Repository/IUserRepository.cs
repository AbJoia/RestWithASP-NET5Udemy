using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository
{
    public interface IUserRepository
    {
        User ValidateCredential(UserVO user);

        User ValidateCredential(string userName);

        bool RevokeToken(string userName);

        User RefreshUserInfo(User user);
    }
}
