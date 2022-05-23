// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace Identiteption.Models.Identities.Exceptions
{
    public class IdentityServiceException : Xeption
    {
        public IdentityServiceException(Exception innerException) :
            base(message: "Identity service error occurred, contact support.", innerException)
        { }
    }
}
