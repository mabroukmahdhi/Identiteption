// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Identiteption.Services.Foundations.Identities;
using Tynamix.ObjectFiller;

namespace Identiteption.Tests.Unit.Services.Foundations.Identities
{
    public partial class IdentityServiceTests
    {
        private readonly IIdentityService identityService;

        public IdentityServiceTests()
        {
            this.identityService = new IdentityService();
        }


        private static string GetRandomString() =>
            new MnemonicString().GetValue();
    }
}
