// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DeviceRegistry.Outputs
{

    /// <summary>
    /// The x509 certificate for authentication mode Certificate.
    /// </summary>
    [OutputType]
    public sealed class X509CredentialsResponse
    {
        /// <summary>
        /// A reference to secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        public readonly string CertificateReference;

        [OutputConstructor]
        private X509CredentialsResponse(string certificateReference)
        {
            CertificateReference = certificateReference;
        }
    }
}
