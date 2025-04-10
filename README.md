# BookStoreAPI

A modern RESTful API for managing a bookstore's inventory and orders. This API is built with ASP.NET Core and deployed on Render.com.

## 🚀 Features

- RESTful API endpoints for books and orders
- Entity Framework Core for data management
- Swagger/OpenAPI documentation
- Clean architecture and SOLID principles
- DBeaver compatible database management

## 🔧 Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core
- SQL Server (Hosted on Render.com)
- DBeaver (Database Management Tool)

## 📚 API Documentation

### Base URL

```
https://bookstoreapi.onrender.com
```

### Endpoints

#### Books

| Method | Endpoint                           | Description                          |
| ------ | ---------------------------------- | ------------------------------------ |
| GET    | `/api/books`                       | Get all books with categories        |
| GET    | `/api/books/{id}`                  | Get book by ID with category details |
| GET    | `/api/books/search`                | Search books by title                |
| GET    | `/api/books/category/{categoryId}` | Get books by category ID             |
| POST   | `/api/books`                       | Create new book                      |
| PUT    | `/api/books/{id}`                  | Update book                          |
| DELETE | `/api/books/{id}`                  | Delete book                          |

#### Orders

| Method | Endpoint                  | Description         |
| ------ | ------------------------- | ------------------- |
| GET    | `/api/orders/{id}`        | Get order by ID     |
| POST   | `/api/orders`             | Create new order    |
| PUT    | `/api/orders/{id}/status` | Update order status |

## 📦 Models

### Book

```json
{
  "id": "int",
  "title": "string",
  "author": "string",
  "price": "decimal",
  "categoryId": "int",
  "category": "Category",
  "stockQuantity": "int"
}
```

### Order

```json
{
  "id": "int",
  "bookId": "int",
  "quantity": "int",
  "totalPrice": "decimal",
  "orderDate": "DateTime",
  "status": "OrderStatus",
  "book": "Book"
}
```

## 🛠️ Setup and Installation

1. Clone the repository:

```bash
git clone https://github.com/yusufinc/BookStoreAPI.git
```

2. Navigate to the project directory:

```bash
cd BookStoreAPI
```

3. Install dependencies:

```bash
dotnet restore
```

4. Configure the database connection in `appsettings.json`

5. Run the application:

```bash
dotnet run
```

## 🔗 Database Connection

The application uses SQL Server hosted on Render.com. You can connect to the database using DBeaver.

## 📝 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📫 Contact

For any questions or suggestions, please open an issue in the repository.
