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
