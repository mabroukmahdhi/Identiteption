// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace Identiteption.Models.Identities.Exceptions
{
    public class FailedIdentityServiceException : Xeption
    {
        public FailedIdentityServiceException(Exception innerException)
            : base(message: "Failed identity service occurred, please contact support", innerException)
        { }
    }
}
