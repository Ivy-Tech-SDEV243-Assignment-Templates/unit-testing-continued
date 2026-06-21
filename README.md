# Unit Testing Continued

## Template Repository

The template repository for this assignment is: [unit-testing-continued](https://github.com/Ivy-Tech-SDEV243-Assignment-Templates/unit-testing-continued).

**_Do not work directly from the starter template if using CodeSpaces! make sure to first click "Use this template" and create a repository in your personal account, then create the CodeSpace from your repository page._**

## Introduction

In this assignment we will continue to work with the Vehicle Simulator application. We will add a new test suite, and explore how to increase reliability of the codebase by adding tests.

This assignment has a video walkthrough to accompany the written instructions. Some checkpoints will require you to complete work on your own.

Be sure to match any provided video output exactly, including:

- filenames
- code
- comments
- commit messages
- screenshots

## Learning Goals

- Create a new project to hold tests
- Add a new class to house tests for functionality
- Determine which parts of the codebase are most important to test
- Compose effective unit tests

## Checkpoints

### Check1: Identifying what to test

**On Your Own:** this checkpoint contains functionality that you must complete on your own.

During the development process we typically write tests either before or along with the related code, instead of writing tests afterward. In this project the application is already complete, so we will review functionality and determine which parts of the `Vehicle` class are most important to test.

_Deliverables:_

- `VehicleTestCases.md` file completed
  - Contains tests identified in video
  - _On Your Own:_ Contains five remaining tests that you have identified on your own.
- Commit with message "check1".

### Check2: Creating a new test project

In thie checkpoint we will add an xUnit test project to the solution.

_Deliverables:_

- New xUnit test project created in `tests` folder and added to solution file (`VehicleSimulator.slnx`).
  - Project name is `VehicleSimulator.Test`.
  - Default class removed.
- Commit with message "check2".

### Check3: Creating a new test class

In this checkpoint we will create a new test class to house tests for the `Vehicle` class. At the end of this checkpoint you should have one test file with one failing test.

_Deliverables:_

- New `VehicleTest.cs` test class created in `tests/VehicleSimulator.Test` folder.
- Test class contains single placeholder failing test.
- Commit with message "check3".

### Check4: Adding existing tests

In this checkpoint we will add the listed starter tests to the `VehicleTest.cs` file.

_Deliverables:_

- `VehicleTest.cs`: Modified with starter tests added.
- Commit with message "check4".

### Check5: Adding tests that you identified

**On Your Own:** this checkpoint contains functionality that you must complete on your own.

In this checkpoint you will add the tests from the `VehicleTestCases.md` file to the `VehicleTest.cs` file.

_Deliverables:_

- `VehicleTest.cs`: Modified with tests from `VehicleTestCases.md` added.
- Commit with message "check5".

## Submission

After completing all checkpoints:

- Confirm that the checkpoints exist in the remote repository
- Check the rubric to see if all requirements were met
- Submit the URL to the root of your GitHub Repository, `https://github.com/[your-username]]/unit-testing-continued`
