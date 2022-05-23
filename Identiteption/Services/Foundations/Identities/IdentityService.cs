using Identiteption.Models.Identities.Exceptions;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Identiteption.Services.Foundations.Identities
{
    public class IdentityService : IIdentityService,IDisposable
    {
        private readonly IDictionary<string, string> exceptionsDictionairy =
            new Dictionary<string, string>()
        {
            { "ConcurrencyFailure",nameof(FailedIdentityServiceException) },
            { "RecoveryCodeRedemptionFailed",nameof(FailedIdentityServiceException) },

            { "DefaultError",nameof(IdentityServiceException) },
            { "LoginAlreadyAssociated",nameof(IdentityServiceException) },
            { "UserLockoutNotEnabled",nameof(IdentityServiceException) },
            { "UserNotInRole",nameof(IdentityServiceException) },

            { "DuplicateEmail" ,nameof(IdentityValidationException)},
            { "DuplicateRoleName" ,nameof(IdentityValidationException)},
            { "DuplicateUserName" ,nameof(IdentityValidationException)},
            { "InvalidEmail" ,nameof(IdentityValidationException)},
            { "InvalidRoleName" ,nameof(IdentityValidationException)},
            { "InvalidToken" ,nameof(IdentityValidationException)},
            { "InvalidUserName" ,nameof(IdentityValidationException)},
            { "PasswordMismatch" ,nameof(IdentityValidationException)},
            { "PasswordRequiresDigit" ,nameof(IdentityValidationException)},
            { "PasswordRequiresLower"  ,nameof(IdentityValidationException)},
            { "PasswordRequiresNonAlphanumeric" ,nameof(IdentityValidationException)},
            { "PasswordRequiresUniqueChars" ,nameof(IdentityValidationException)},
            { "PasswordRequiresUpper" ,nameof(IdentityValidationException)},
            { "PasswordTooShort" ,nameof(IdentityValidationException)},
            { "UserAlreadyHasPassword " ,nameof(IdentityValidationException)},
            { "UserAlreadyInRole" ,nameof(IdentityValidationException) }
        };

        public void CreateAndThrowIdentityException(IdentityResult identityResult)
        {
            if (identityResult == null)
            {
                var exception = new Exception("Identity result is null.");
                throw CreateValidationException(exception);
            }

            SelectAndThrow(identityResult.Errors, nameof(IdentityValidationException));

            SelectAndThrow(identityResult.Errors, nameof(IdentityServiceException));

            SelectAndThrow(identityResult.Errors, nameof(FailedIdentityServiceException));
        }

        private void SelectAndThrow(IEnumerable<IdentityError> errors, string exceptionName)
        {
            var validationErrors = errors?.Where(e =>
               exceptionsDictionairy[e.Code].Equals(exceptionName));

            if (validationErrors?.Any() == true)
            {
                switch (exceptionName)
                {
                    case nameof(IdentityValidationException):
                        CreateValidationException(validationErrors)
                            .ThrowIfContainsErrors();
                        break;

                    case nameof(IdentityServiceException):
                        CreateServieException(validationErrors)
                            .ThrowIfContainsErrors();
                        break;

                    case nameof(FailedIdentityServiceException):
                        CreateFailedServieException(validationErrors)
                           .ThrowIfContainsErrors();
                        break;

                    default:
                        break;
                }

            }
        }

        private IdentityValidationException CreateValidationException(
            Exception exception) =>
            new(exception);

        private IdentityValidationException CreateValidationException(
            IEnumerable<IdentityError> errors)
        {
            var innerException = new Exception("Identity result contains errors.");

            var validationException = CreateValidationException(innerException);

            foreach (var error in errors)
            {
                validationException.UpsertDataList(error.Code, error.Description);
            }

            return validationException;
        }

        private FailedIdentityServiceException CreateFailedServieException(
            IEnumerable<IdentityError> errors)
        {
            var innerException = new Exception("Identity result contains errors.");

            var failedIdentityServiceException = new FailedIdentityServiceException(innerException);

            foreach (var error in errors)
            {
                failedIdentityServiceException.UpsertDataList(error.Code, error.Description);
            }

            return failedIdentityServiceException;
        }

        private IdentityServiceException CreateServieException(
            IEnumerable<IdentityError> errors)
        {
            var innerException = new Exception("Identity result contains errors.");

            var identityServiceException = new IdentityServiceException(innerException);

            foreach (var error in errors)
            {
                identityServiceException.UpsertDataList(error.Code, error.Description);
            }

            return identityServiceException;
        }

        public void Dispose()
        {
            
        }
    }
}
