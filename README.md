# **Province_api**

This repository contains an API for managing information about provinces/cities, districts, and wards in Vietnam.

## **Overview**
This API is built using **.NET 6.0** framework and serves as a tool to facilitate the management of geographical information relevant to Vietnam. It provides endpoints to retrieve, create, update, and delete data related to provinces/cities, districts, and wards.

## **Features**
- **Retrieve Information:** Endpoints are available to fetch details about provinces/cities, districts, and wards individually or in combination.
- **Create:** Allows users to add new provinces/cities, districts, and wards to the database.
- **Update:** Enables users to modify existing information, such as names, codes, or boundaries.
- **Delete:** Provides functionality to remove provinces/cities, districts, or wards from the database.

## **Technologies Used**
- **.NET 6.0:** Latest version of the .NET framework, offering performance improvements and new features.
- **C#:** Primary programming language for building the API.
- **Entity Framework Core:** Utilized for database interactions, providing an object-relational mapper (ORM) for working with databases using .NET objects.
- **Swagger/OpenAPI:** Integrated for easy API documentation and testing.

## **Installation**
To run the API locally, ensure you have the following prerequisites installed:

- **.NET 6.0 SDK:** [Download](https://dotnet.microsoft.com/download)
- Your preferred IDE or code editor (e.g., Visual Studio, Visual Studio Code)

Clone this repository to your local machine:

```bash
git clone https://github.com/vuduchoainam/provience_api.git
```
Navigate to the project directory and restore dependencies:
```bash
cd provience_api
dotnet restore
```
Run the application:
```bash
dotnet run
```
The API will be accessible at https://localhost:5001 by default.

## **API Documentation**

Swagger/OpenAPI documentation is available to explore and test the API endpoints. Once the application is running locally, visit the following URL in your web browser:
```bash
https://localhost:5001/swagger/index.html
```
## **Contributing**
Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

- Fork the repository
- Create your feature branch (git checkout -b feature/YourFeature)
- Commit your changes (git commit -am 'Add some feature')
- Push to the branch (git push origin feature/YourFeature)
- Open a pull request
- Please ensure your pull request adheres to the repository's code style and includes relevant tests if applicable.






