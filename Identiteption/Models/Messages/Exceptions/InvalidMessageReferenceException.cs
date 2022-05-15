// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------
using System;
using Xeptions;

namespace Identiteption.Models.Messages.Exceptions
{
    public class InvalidMessageReferenceException : Xeption
    {
        public InvalidMessageReferenceException(Exception innerException)
            : base(message: "Invalid Message reference error occurred.", innerException) { }
    }
}