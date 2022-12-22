// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.Cryptography.X509Certificates;

namespace System.Security.Policy
{
    public sealed partial class PublisherMembershipCondition : ISecurityEncodable, ISecurityPolicyEncodable, IMembershipCondition
    {
        public PublisherMembershipCondition(X509Certificate certificate) { }
        public X509Certificate Certificate { get; set; }
        public bool Check(Evidence evidence) { return false; }
        public IMembershipCondition Copy() { return this; }
        public override bool Equals(object o) => base.Equals(o);
        public void FromXml(SecurityElement e) { }
        public void FromXml(SecurityElement e, PolicyLevel level) { }
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => base.ToString();
        public SecurityElement ToXml() { return default(SecurityElement); }
        public SecurityElement ToXml(PolicyLevel level) { return default(SecurityElement); }
    }
}
