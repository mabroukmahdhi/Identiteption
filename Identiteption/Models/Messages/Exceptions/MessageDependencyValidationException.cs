// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------
using Xeptions;

namespace Identiteption.Models.Messages.Exceptions
{
    public class MessageDependencyValidationException : Xeption
    {
        public MessageDependencyValidationException(Xeption innerException)
            : base(message: "Message dependency validation occurred, please try again.", innerException)
        { }
    }
}
