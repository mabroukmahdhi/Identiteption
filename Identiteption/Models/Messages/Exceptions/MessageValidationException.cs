// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------
using Xeptions;

namespace Identiteption.Models.Messages.Exceptions
{
    public class MessageValidationException : Xeption
    {
        public MessageValidationException(Xeption innerException)
            : base(message: "Message validation errors occurred, please try again.",
                  innerException)
        { }
    }
}
