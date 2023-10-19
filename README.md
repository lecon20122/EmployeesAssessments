## Project Structure

| Directory/Project | Description |
| --- | --- |
| `src/` | This folder contains the source code of your application. It is divided into several projects: |
| `src/Core/Application` | The Application Layer contains application logic, including use cases, Contracts, Exceptions, Features, and Models for Other External Services like Identity. It acts as a bridge between the API Layer and the Domain Layer. This is where you define the the core business logic and handle use cases. |
| `src/Core/Domain` | The Domain Layer contains the core business logic and domain entities. This layer should be independent of any infrastructure concerns and should represent the heart of your application's functionality. |
| `src/Infrastructure/Persistence` | The Persistence Layer is responsible for Implementing the Core Application Contracts. It is responsible for persisting the data to the database |
| `src/Infrastructure/Identity` | The Identity Layer is responsible for data access, and the Implementation of Identity Authentication. |
| `src/API` | The API Layer is responsible for the user interface, whether it's a web application, API, or another user-facing component. It interacts with the Application Layer to serve user requests. |
