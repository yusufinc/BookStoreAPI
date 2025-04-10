# BookStoreAPI

A modern RESTful API for managing a bookstore's inventory, orders, and categories. This API is built with ASP.NET Core and deployed on Render.com.

## 🚀 Features

- RESTful API endpoints for books, orders, and categories
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

| Method | Endpoint          | Description     |
| ------ | ----------------- | --------------- |
| GET    | `/api/books`      | Get all books   |
| GET    | `/api/books/{id}` | Get book by ID  |
| POST   | `/api/books`      | Create new book |
| PUT    | `/api/books/{id}` | Update book     |
| DELETE | `/api/books/{id}` | Delete book     |

#### Orders

| Method | Endpoint           | Description      |
| ------ | ------------------ | ---------------- |
| GET    | `/api/orders`      | Get all orders   |
| GET    | `/api/orders/{id}` | Get order by ID  |
| POST   | `/api/orders`      | Create new order |
| PUT    | `/api/orders/{id}` | Update order     |
| DELETE | `/api/orders/{id}` | Delete order     |

#### Categories

| Method | Endpoint               | Description         |
| ------ | ---------------------- | ------------------- |
| GET    | `/api/categories`      | Get all categories  |
| GET    | `/api/categories/{id}` | Get category by ID  |
| POST   | `/api/categories`      | Create new category |
| PUT    | `/api/categories/{id}` | Update category     |
| DELETE | `/api/categories/{id}` | Delete category     |

## 📦 Models

### Book

```json
{
  "id": "int",
  "title": "string",
  "author": "string",
  "price": "decimal",
  "categoryId": "int",
  "category": "Category"
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
  "book": "Book"
}
```

### Category

```json
{
  "id": "int",
  "name": "string",
  "books": "List<Book>"
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

The application uses SQL Server hosted on Render.com. You can connect to the database using DBeaver with the following credentials:

- Host: [Your Render.com database host]
- Port: 5432
- Database: [Your database name]
- Username: [Your username]
- Password: [Your password]

## 📝 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📫 Contact

For any questions or suggestions, please open an issue in the repository.
