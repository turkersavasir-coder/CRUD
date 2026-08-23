# C# SQL Server CRUD Application

This project is a simple **C# and SQL Server CRUD application** developed to practice database operations using ADO.NET.

The application demonstrates how to connect a C# application to SQL Server and perform basic **Create, Read, Update, and Delete (CRUD)** operations.

## 🚀 Technologies Used

* **C#**
* **.NET**
* **SQL Server**
* **Microsoft.Data.SqlClient**
* **ADO.NET**
* `SqlConnection`
* `SqlCommand`
* `SqlDataAdapter`
* `DataTable`
* `DataRow`

## 📌 Features

### Create

Add new categories and products to the database.

### Read

Retrieve products from SQL Server and display them in the console.

### Update

Update an existing product's name and price using its ID.

### Delete

Delete a product from the database using its ID.

## 🗄️ Database

The project uses SQL Server with the following tables:

### CategoryTable

| Column          | Description   |
| --------------- | ------------- |
| `category_name` | Category name |

### Producttab

| Column           | Description    |
| ---------------- | -------------- |
| `Product_id`     | Product ID     |
| `Product_Name`   | Product name   |
| `Product_Price`  | Product price  |
| `Product_Status` | Product status |

## 🔌 Connection String

The current project uses a local SQL Server connection:

```text
Server=localhost;
Database=master;
Integrated Security=True;
TrustServerCertificate=True;
```

You may need to modify the connection string according to your SQL Server configuration.

## 🔐 SQL Parameters

The project uses SQL parameters when sending user input to the database.

Example:

```csharp
command1.Parameters.AddWithValue("@productName", Product_Namee);
command1.Parameters.AddWithValue("@productId", Product_idd);
command1.Parameters.AddWithValue("@productPrice", Product_Pricee);
```

Using parameters makes SQL queries safer and helps prevent SQL injection when handling user input.

## 📚 CRUD Operations

The project includes examples of:

```sql
INSERT
SELECT
UPDATE
DELETE
```

For example, updating a product:

```sql
UPDATE Producttab
SET Product_Name = @productName,
    Product_Price = @productPrice
WHERE Product_id = @productId
```

## ▶️ How to Run

1. Install and run **SQL Server**.
2. Create the required database tables.
3. Open the project in Visual Studio or VS Code.
4. Make sure `Microsoft.Data.SqlClient` is installed.
5. Update the connection string if necessary.
6. Build and run the project.

## 🎯 Project Purpose

The main purpose of this project is to practice connecting **C# applications with SQL Server** and understand how database operations work in a backend application.

The project provides hands-on practice with:

* SQL Server connections
* ADO.NET
* `SqlConnection`
* `SqlCommand`
* `SqlDataAdapter`
* `DataTable`
* SQL parameters
* CRUD operations
* Console-based user input

## 🔮 Future Improvements

* [ ] Add a complete console menu
* [ ] Add exception handling with `try-catch`
* [ ] Improve connection management with `using`
* [ ] Replace `AddWithValue` with strongly typed parameters
* [ ] Add product search
* [ ] Add product filtering
* [ ] Add category-product relationships
* [ ] Use Foreign Keys
* [ ] Add Stored Procedures
* [ ] Implement a layered architecture
* [ ] Implement Repository Pattern
* [ ] Convert the project into an ASP.NET Core Web API

## 👨‍💻 Learning Project

This project was created as part of my **C# and backend development learning journey**.

It starts with basic database operations and can later be expanded into a more advanced backend application.
