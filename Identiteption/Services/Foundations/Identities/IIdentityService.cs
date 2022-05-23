// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Identity;

namespace Identiteption.Services.Foundations.Identities
{
    public interface IIdentityService
    {
        void CreateAndThrowIdentityException(IdentityResult identityResult);
    }
}
