// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------
using System;
using Xeptions;

namespace Identiteption.Models.Messages.Exceptions
{
    public class FailedMessageStorageException : Xeption
    {
        public FailedMessageStorageException(Exception innerException)
            : base(message: "Failed Message storage error occurred, contact support.", innerException)
        { }
    }
}
