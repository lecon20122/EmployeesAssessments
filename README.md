## React Page (Nextjs)
the [Employee Assessment Client Repo](https://github.com/lecon20122/EmployeeAssessmentClient) contains the client app for the task, using Nextjs Framework and Tailwindcss.

## Seed Data
I've included seed data to help you get started more easily. This seed data will populate the database with initial records, making it easier to test and explore the application's functionality.

## Packages Used

In this project, we've used the following packages, along with their latest versions at the time of this task:

- AutoMapper: v12.0.1
- MediatR: v12.1.1
- Identity Framework: v7.0.12
- Entity Framework Core: v7.0.12
- JwtBearer v7.0.12


## Project Structure

| Directory/Project | Description |
| --- | --- |
| `src/` | This folder contains the source code of your application. It is divided into several projects: |
| `src/Core/Application` | The Application Layer contains application logic, including use cases, Contracts, Exceptions, Features, and Models for Other External Services like Identity. It acts as a bridge between the API Layer and the Domain Layer. This is where you define the core business logic and handle use cases. |
| `src/Core/Domain` | The Domain Layer contains the core business logic and domain entities. This layer should be independent of any infrastructure concerns and should represent the heart of your application's functionality. |
| `src/Infrastructure/Persistence` | The Persistence Layer is responsible for Implementing the Core Application Contracts. It is responsible for persisting the data to the database |
| `src/Infrastructure/Identity` | The Identity Layer is responsible for data access, and the Implementation of Identity Authentication. |
| `src/API` | The API Layer is responsible for the user interface, whether it's a web application, API, or another user-facing component. It interacts with the Application Layer to serve user requests. |

## Vertically Sliced Architecture

In this project, I've adopted a Vertically Sliced architecture based on the Clean Architecture principles. A Vertically Sliced architecture is an approach to structuring your application that emphasizes organizing code around specific features or use cases.

 in `src/Core/Application/Features`, each feature has its own view models and DTOs, also the Commands and Queries  

The benefits of a Vertically Sliced architecture include improved maintainability, reduced coupling between unrelated features, and the ability to develop and test features independently.
