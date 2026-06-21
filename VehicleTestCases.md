# Test Cases for Vehicle Class

## Refuel Behavior

Related to vehicle's refueling behavior.

### Tests

1. refuel_increases_fuel_level_by_amount

Verifies that the `Refuel` method increases the vehicle's fuel level by the specified amount. This is the happy path case for refueling.

2. refuel_clamps_fuel_level_to_max_fuel_level

Verifies that the `Refuel` method does not allow the vehicle's fuel level to exceed the maximum fuel level.

3. refuel_does_not_allow_negative_amount

Verifies that the `Refuel` method should throw an exception if the fuel amount is negative.

## Drive Behavior

Related to vehicle's driving behavior.

### Instructions

**On your own:** identify three additional tests for the `Vehicle` class that verify the expected behavior of the `Drive` method. Replace the TODO: items to match the format from above.

Keep in mind the unit testing guidelines:

- Use test names that a non-programmer who is familiar with the application can understand
- Test only observable (public) behavior
- Focus on complex functionality
- Focus on application critical functionality
- Identify and verify happy path and edge cases.

### Tests

1. TODO: your_test_name

TODO: Your test description here.

2. TODO: your_test_name

TODO: Your test description here.

3. TODO: your_test_name

TODO: Your test description here.
