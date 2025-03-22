using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    public enum ConnectorAuthType
    {
        [Description("None")]
        None,
        [Description("Basic Auth")]
        Basic,
        [Description("NTLM")]
        Ntlm,
        [Description("Windows")]
        Windows,
        [Description("MS Entra ID")]
        OAUthMsEntraId,
        [Description("OAuth2: Client Credentials (Body Auth)")]
        OAuth2ClientCredentialsBodyAuth,
        [Description("OAuth2: Client Credentials (Basic Auth)")]
        OAuth2ClientCredentialsBasicAuth
    }
}