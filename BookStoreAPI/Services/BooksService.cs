using System;
using BookStoreAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BookStoreAPI.Services
{
    public class BooksService
    {
        // Gets a collection based on the model <Book>.
        private readonly IMongoCollection<Book> _booksCollection;

        public BooksService(
            IOptions<BookStoreDatabaseSettings> bookStoreDatabaseSettings)
        {
            // Get ConnectionString from BookStoreDatabaseSettings in Models Directory
            var mongoClient = new MongoClient(
                bookStoreDatabaseSettings.Value.ConnectionString);

            // Get DatabaseName from BookStoreDatabaseSettings in Models Directory
            var mongoDatabase = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);

            // Get CollectionName from BookStoreDatabaseSettings in Models Directory
            _booksCollection = mongoDatabase.GetCollection<Book>(
                bookStoreDatabaseSettings.Value.CollectionName);
        }

        // Get
        public async Task<List<Book>> GetAsync() =>
            await _booksCollection.Find(_ => true).ToListAsync();

        // Get {id}
        public async Task<Book?> GetAsync(string id) =>
            await _booksCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        // Post
        public async Task CreateAsync(Book newBook) =>
            await _booksCollection.InsertOneAsync(newBook);

        // Put {id}
        public async Task UpdateAsync(string id, Book updatedBook) =>
            await _booksCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        // Delete {id}
        public async Task RemoveAsync(string id) =>
            await _booksCollection.DeleteOneAsync(x => x.Id == id);
    }
}

