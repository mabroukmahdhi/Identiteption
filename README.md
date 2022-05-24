<p align="center">
  <img width="15%" height="15%" src="https://github.com/mabroukmahdhi/Identiteption/blob/main/Assets/logo.png?raw=true">
</p>

### Nuget

[![Nuget](https://img.shields.io/nuget/v/Identiteption)](https://www.nuget.org/packages/Identiteption/)
[![Nuget](https://img.shields.io/nuget/dt/Identiteption)](https://www.nuget.org/packages/Identiteption/)

### Social
[![Twitter Follow](https://img.shields.io/twitter/follow/Mabrouk_Mahdhi?style=social)](https://twitter.com/Mabrouk_Mahdhi)

# Identiteption
.Net Library that throws exceptions based on Microsoft Identity Result `IdentityResult`.

# About Identity Error Codes

Source: [IdentityResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.identityerrordescriber?view=aspnetcore-6.0)

## Possible error codes
- ConcurrencyFailure
- DefaultError
- DuplicateEmail
- DuplicateRoleName
- DuplicateUserName
- InvalidEmail
- InvalidRoleName
- InvalidToken
- InvalidUserName
- LoginAlreadyAssociated
- PasswordMismatch
- PasswordRequiresDigit
- PasswordRequiresLower
- PasswordRequiresNonAlphanumeric
- PasswordRequiresUniqueChars
- PasswordRequiresUpper
- PasswordTooShort
- RecoveryCodeRedemptionFailed
- UserAlreadyHasPassword
- UserAlreadyInRole
- UserLockoutNotEnabled
- UserNotInRole

## What exception?
There are three types of exceptions that can be thrown: `IdentityValidationException`, `FailedIdentityServiceException` or `IdentityServiceException`.

| Error code | Throws `IdentityValidationException` | Throws `FailedIdentityServiceException` | Throws `IdentityServiceException`|
| -----------| ------------------------------------ | --------------------------------------- | -------------------------------- |
| ConcurrencyFailure |  | X | |
| DefaultError | |  | X |
| DuplicateEmail | X |  |  |
| DuplicateRoleName | X |  |  |
| DuplicateUserName| X |  |  |
| InvalidEmail| X |  |  |
| InvalidRoleName| X |  |  |
| InvalidToken | X |  |  |
| InvalidUserName | X |  |  |
| LoginAlreadyAssociated|  |  | X |
| PasswordMismatch | X |  |  |
| PasswordRequiresDigit | X |  |  |
| PasswordRequiresLower | X |  |  |
| PasswordRequiresNonAlphanumeric | X |  |  |
| PasswordRequiresUniqueChars | X |  |  |
| PasswordRequiresUpper | X |  |  |
| PasswordTooShort | X |  |  |
| RecoveryCodeRedemptionFailed |  | X |  |
| UserAlreadyHasPassword| X |  |  |
| UserAlreadyInRole | X |  |  |
| UserLockoutNotEnabled |  |  | X |
| UserNotInRole|  |  | X |

# Usage
It is very easy and simple to use this, you only need to call the extension `Throw`:

```cs
IdentityResult identityResult = ....;

identityResult.Throw();
```
