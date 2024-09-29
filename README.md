# SurveyJS-BlazorWsam: A Blazor WebAssembly Survey Application

## Overview

SurveyBlazor is a proof of concept application demonstrating the integration of a Blazor WebAssembly frontend with an ASP.NET Core Web API backend. The application allows users to complete surveys and view survey results.

## Key Features

1. Survey Creation and Submission
2. Survey Results Display
3. Client-Side Rendering with Blazor WebAssembly
4. Server-Side Data Storage with Entity Framework Core
5. RESTful API for Data Communication

## Project Structure

The solution is divided into two main projects:

### SurveyBlazor.Web (Blazor WebAssembly)

- `SurveyComponent.razor`: Renders the survey form using SurveyJS and handles survey submission.
- `SurveyResult.cs`: Defines the model for survey results.
- `Home.razor`: The main page that includes the SurveyComponent.
- `SurveyResults.razor`: Displays a list of submitted survey results.
- `Program.cs`: Configures the Blazor WebAssembly application.

### SurveyBlazor.Api (ASP.NET Core Web API)

- `SurveyController.cs`: Handles HTTP requests for survey operations (GET and POST).
- `ApplicationDbContext.cs`: Defines the Entity Framework Core context for database operations.
- `Program.cs`: Configures the API application, including database context and CORS policy.

## Key Technologies

- Blazor WebAssembly
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (as the database provider)
- SurveyJS (for survey rendering)

## Functionality

1. Users can complete surveys rendered by SurveyJS on the home page.
2. Submitted survey data is sent to the API and stored in the database.
3. Users can view all submitted survey results on the Survey Results page.

## Setup and Configuration

1. Ensure you have the .NET 6 SDK or later installed.
2. Set up a SQL Server instance and update the connection string in `appsettings.json` of the API project.
3. Run Entity Framework Core migrations to create the database schema.
4. Start both the API and Web projects.
5. Access the application through the Blazor WebAssembly project's URL (default: http://localhost:5018).

## Future Enhancements

- User authentication and authorization
- Custom survey creation interface
- More detailed survey result analysis and visualization
- Improved error handling and user feedback

This proof of concept demonstrates the potential for creating interactive, data-driven web applications using Blazor WebAssembly with a .NET backend, showcasing how modern web technologies can be leveraged to create responsive and efficient survey tools.
