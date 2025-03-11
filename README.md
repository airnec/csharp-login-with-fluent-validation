### Scenario:

User Login System with Fluent Validation

Scenario Description:

The user will fill out a registration form and will need to follow these rules:

- Email must be in a valid format.
- Password must be at least 8 characters, one uppercase letter, one lowercase letter, and one number.
- Username must be at least 3 characters long.

Steps:

- Install the FluentValidation package.
- Create a UserModel and write validation rules.
- Create the Validator class and use Fluent Validation.
- Perform the validation process in the Controller.
- Send errors to the View and display them to the user.