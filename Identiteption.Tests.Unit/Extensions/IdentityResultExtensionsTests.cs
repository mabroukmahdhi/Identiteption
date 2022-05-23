// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using FluentAssertions;
using Identiteption.Extensions;
using Identiteption.Models.Identities.Exceptions;
using Microsoft.AspNetCore.Identity;
using System;
using Tynamix.ObjectFiller;
using Xunit;

namespace Identiteption.Tests.Unit.Extensions
{
    public class IdentityResultExtensionsTests
    {

        [Fact]
        public void ShouldThrowValidationExceptionIfIdentityResultIsNull()
        {
            // given
            IdentityResult inputIdentityResult = null;

            // when
            Action createAndThrowAction = () => inputIdentityResult.Throw();

            // then
            createAndThrowAction.Should().Throw<IdentityValidationException>();
        }

        [Theory]
        [InlineData("DefaultError")]
        [InlineData("LoginAlreadyAssociated")]
        [InlineData("UserLockoutNotEnabled")]
        [InlineData("UserNotInRole")]
        public void ShouldThrowServiceException(string errorCode)
        {
            // given
            string randomMessage = GetRandomString();
            var inputIdentityResult = IdentityResult.Failed(new IdentityError()
            {
                Code = errorCode,
                Description = randomMessage
            });

            // when
            Action createAndThrowAction = () => inputIdentityResult.Throw();

            // then

            createAndThrowAction.Should().Throw<IdentityServiceException>();
        }

        [Theory]
        [InlineData("DuplicateEmail")]
        [InlineData("DuplicateRoleName")]
        [InlineData("DuplicateUserName")]
        [InlineData("InvalidEmail")]
        [InlineData("InvalidRoleName")]
        [InlineData("InvalidToken")]
        [InlineData("InvalidUserName")]
        [InlineData("PasswordMismatch")]
        [InlineData("PasswordRequiresDigit")]
        [InlineData("PasswordRequiresLower")]
        [InlineData("PasswordRequiresNonAlphanumeric")]
        [InlineData("PasswordRequiresUniqueChars")]
        [InlineData("PasswordRequiresUpper")]
        [InlineData("PasswordTooShort")]
        [InlineData("UserAlreadyHasPassword ")]
        [InlineData("UserAlreadyInRole")]
        public void ShouldThrowValidationException(string errorCode)
        {
            // given
            string randomMessage = GetRandomString();
            var inputIdentityResult = IdentityResult.Failed(new IdentityError()
            {
                Code = errorCode,
                Description = randomMessage
            });

            // when
            Action createAndThrowAction = () => inputIdentityResult.Throw();

            // then

            createAndThrowAction.Should().Throw<IdentityValidationException>();
        }

        [Theory]
        [InlineData("ConcurrencyFailure")]
        [InlineData("RecoveryCodeRedemptionFailed")]
        public void ShouldThrowFailedServiceException(string errorCode)
        {
            // given
            string randomMessage = GetRandomString();
            var inputIdentityResult = IdentityResult.Failed(new IdentityError()
            {
                Code = errorCode,
                Description = randomMessage
            });

            // when
            Action createAndThrowAction = () => inputIdentityResult.Throw();

            // then

            createAndThrowAction.Should().Throw<FailedIdentityServiceException>();
        }

        private static string GetRandomString() =>
         new MnemonicString().GetValue();
    }
}
