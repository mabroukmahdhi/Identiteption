// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------
using System;
using Xeptions;

namespace Identiteption.Models.Messages.Exceptions
{
    public class LockedMessageException : Xeption
    {
        public LockedMessageException(Exception innerException)
            : base(message: "Locked Message record exception, please try again later", innerException) { }
    }
}
