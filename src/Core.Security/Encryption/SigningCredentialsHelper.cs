using Microsoft.IdentityModel.Tokens;

namespace Core.Security.Encryption;

public static class SigningCredentialsHelper
{
    public static SigningCredentials CreateSigningCredentials(SecurityKey securiyKey) => new(securiyKey, SecurityAlgorithms.HmacSha512Signature);
}
