using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents the authentication type for a connector.
    /// </summary>
    public enum ConnectorAuthType
    {
        /// <summary>
        /// No authentication.
        /// </summary>
        [Description("None")]
        None,
        
        /// <summary>
        /// Basic authentication.
        /// </summary>
        [Description("Basic Auth")]
        Basic,
        
        /// <summary>
        /// NTLM authentication.
        /// </summary>
        [Description("NTLM")]
        Ntlm,
        
        /// <summary>
        /// Windows authentication.
        /// </summary>
        [Description("Windows")]
        Windows,

        /// <summary>
        /// Microsoft Entra ID authentication.
        /// </summary>
        [Description("MS Entra ID")]
        OAUthMsEntraId,

        /// <summary>
        /// OAuth2 client credentials with body authentication.
        /// </summary>
        [Description("OAuth2: Client Credentials (Body Auth)")]
        OAuth2ClientCredentialsBodyAuth,

        /// <summary>
        /// OAuth2 client credentials with basic authentication.
        /// </summary>
        [Description("OAuth2: Client Credentials (Basic Auth)")]
        OAuth2ClientCredentialsBasicAuth
    }
}