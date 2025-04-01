# DeveloperStore

# Ambev Developer Evaluation API

## Overview
Ambev Developer Evaluation API is a backend application designed to manage sales, customers, branches, and products. It follows a clean architecture approach and is built using **.NET Core**, with **PostgreSQL** as the database engine.

## Technologies Used
- **.NET Core**
- **Entity Framework Core**
- **PostgreSQL**
- **Docker**
- **MediatR**
- **FluentValidation**

## Project Structure
The project follows a **Clean Architecture** approach and is organized into different layers:

- **Domain**: Contains core business entities and interfaces.
- **Application**: Implements use cases and business logic.
- **Infrastructure (ORM & Repositories)**: Handles data access with Entity Framework Core.
- **Adapters**:
  - **Driven** (Infrastructure): Implements repositories.
  - **Drivers** (Web API): Exposes API endpoints.

## Features
- **Sales Management**
- **Customers Management**
- **Branches Management**
- **Products Management**

## Installation & Setup

### Prerequisites
Make sure you have the following installed:
- .NET SDK
- PostgreSQL
- Docker (optional, for containerized deployment)

### Configuration
1. Clone the repository:
   ```sh
   git clone https://github.com/your-repo/your-project.git
   cd your-project
   ```
2. Configure the PostgreSQL connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Host=localhost;Port=5432;Database=yourdb;Username=youruser;Password=yourpassword"
   }
   ```

### Running the Application
#### Using .NET CLI
```sh
cd src/YourProject.Api
dotnet run
```

#### Using Docker
```sh
docker-compose up --build
```

### Database Migration
To apply migrations and update the PostgreSQL database, run:
```sh
dotnet ef database update
```

## API Endpoints
The API exposes the following endpoints:

### Sales
- `POST /api/sales` - Create a sale
- `GET /api/sales/{id}` - Get sale by ID
- `GET /api/sales/customer/{customerId}` - Get sales by customer ID

### Customers
- `POST /api/customers` - Create a customer
- `GET /api/customers/{id}` - Get customer by ID

### Branches
- `POST /api/branches` - Create a branch
- `GET /api/branches/{id}` - Get branch by ID

### Products
- `POST /api/products` - Create a product
- `GET /api/products/{id}` - Get product by ID

## License
This project is licensed under the MIT License.
