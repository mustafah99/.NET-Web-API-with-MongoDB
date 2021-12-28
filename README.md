
# Web API with .NET 6 & MongoDB

A Web API built with the latest .NET 6 SDK in Visual Studio to initially learn how MongoDB and how to create a Web API based on data fetched from MongoDB.

See full documentation on how to build a Web API with ASP .NET Core & MongoDB [here](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-6.0&tabs=visual-studio-mac).

## Deployment

To deploy this project first download or clone the source code from this repository.

Then run the project in Visual Studio 2022 with the .NET 6 SDK installed.

Then a window should automatically direct you to the following host URL for the Web API:
```bash
  https://localhost:7215/swagger/index.html
```


## API Reference

#### Get all Books

```http
  GET /api/Books
```

#### Get Book by ID

```http
  GET /api/Books/${id}
```

#### Add New Book by POST

```http
  POST /api/Books/
```
Required parameters:
```http
{
  "Name": "string",
  "Price": 0,
  "Category": "string",
  "Author": "string"
}
```

#### Update Book by ID
```http
  PUT /api/Books/${id}
```
Required parameters:
```http
{
  "Name": "string",
  "Price": 0,
  "Category": "string",
  "Author": "string"
}
```
#### Delete Book by ID
```http
  DELETE /api/Books/${id}
```


## What I've Learned

Here I've learned how to use MongoDB for the first time as well as build a database and collection and connect it with ASP .NET Core (.NET 6) to assemble a Web API with CRUD operations.

I've also learned how to beautify your README.md files for your repository which you can also do using this link below:

[![readme.so-editor](https://readme.so/readme.svg)](https://readme.so/editor)
## Tech Stack used in Repository

**Server:** ASP .NET Core (.NET 6 SDK), MongoDB




![MongoDB](https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/MongoDB_Logo.svg/2560px-MongoDB_Logo.svg.png)

![.NETCore](https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/2048px-.NET_Core_Logo.svg.png)