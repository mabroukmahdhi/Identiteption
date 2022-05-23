// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Identiteption.Services.Foundations.Identities;
using Microsoft.AspNetCore.Identity;

namespace Identiteption.Extensions
{
    public static class IdentityResultExtensions
    {
        public static void Throw(this IdentityResult identityResult)
        {
            using var identityService = new IdentityService();

            identityService.CreateAndThrowIdentityException(identityResult);
        }
    }
}
