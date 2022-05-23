// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace Identiteption.Models.Identities.Exceptions
{
    public class IdentityValidationException : Xeption
    {
        public IdentityValidationException(Exception innerException)
            : base(message: "Identity validation errors occurred, please try again.",
                  innerException)
        { }
    }
}
