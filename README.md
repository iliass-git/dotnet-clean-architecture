# DemoWebApi using Clean Architecture

This is a web API based on .NET 8 that utilizes the Minimal API and CQRS pattern using the MediatR library. The project demonstrates the use of clean architecture to organize the code and decoupling by separating concerns into distinct layers.

## Features

- Implements a clean architecture to organize the code and decoupling by separating concerns into distinct layers.
- Utilizes a web API based on .NET 8 and the Minimal API approach.
- Implements CQRS pattern using the MediatR library.
- Stores and retrieves data from an Azure Cosmos DB using a repository pattern.

## Prerequisites

Before running the API locally, make sure you have the following:

- .NET 8 SDK installed on your machine.
- An Azure Cosmos DB account with the necessary connection details.

## Getting Started

To build and run the API locally, follow these steps:

1. Clone this repository to your local machine.
2. Open a terminal and navigate to the project's root directory.
3. Set the necessary environment variables for connecting to your Azure Cosmos DB.
4. Run the following command to restore the dependencies:

    ```shell
    dotnet restore
    ```

5. Build the project by running the following command:

    ```shell
    dotnet build
    ```

6. Finally, switch to the Webapi folder and start the API by running the following command:

    ```shell
    dotnet run
    ```

The API should now be running locally and accessible at `http://localhost:5075`.

## License

This project is licensed under the [MIT License](LICENSE).