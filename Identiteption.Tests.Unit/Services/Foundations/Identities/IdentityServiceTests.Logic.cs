// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using FluentAssertions;
using Identiteption.Models.Identities.Exceptions;
using Microsoft.AspNetCore.Identity;
using System;
using Xunit;

namespace Identiteption.Tests.Unit.Services.Foundations.Identities
{
    public partial class IdentityServiceTests
    {
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
            Action createAndThrowAction = () => this.identityService.CreateAndThrowIdentityException(inputIdentityResult);

            // then

            createAndThrowAction.Should().Throw<IdentityServiceException>();
        }
    }
}
