using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredencials(UserVO user);
        TokenVO ValidateCredencials(TokenVO token);
        bool RevokeToken(string userName);
    }
}
