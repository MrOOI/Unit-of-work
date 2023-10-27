using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TESTUoW.Repository.DbContext
{
    public class DatabaseContext
    {
        private DatabaseSettings _dbSettings;

        public DatabaseContext(DatabaseSettings dbSettings)
        {
            _dbSettings = dbSettings;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = $"Server={_dbSettings.Server};Encrypt=False; Trusted_Connection=True; TrustServerCertificate=True; Database={_dbSettings.Database}; User Id={_dbSettings.UserId}; Password={_dbSettings.Password}";
            return new SqlConnection(connectionString);
        }

        //public async Task Init()
        //{
        //    await _initDatabase();
        //    await _initTables();
        //}

        //private async Task _initDatabase()
        //{
        //    // create database if it doesn't exist
        //    var connectionString = $"Server={_dbSettings.Server};Encrypt=False; Trusted_Connection=True; TrustServerCertificate=True; Database={_dbSettings.Database}; User Id={_dbSettings.UserId}; Password={_dbSettings.Password}";
        //    using var connection = new SqlConnection(connectionString);
        //    var sql = $"IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = '{_dbSettings.Database}') CREATE DATABASE [{_dbSettings.Database}];";
        //    await connection.ExecuteAsync(sql);
        //}

        //private async Task _initTables()
        //{
        //    // create tables if they don't exist
        //    using var connection = CreateConnection();
        //    await _initUsers();
        //    await _initAccounts();

        //    async Task _initUsers()
        //    {
        //        var sql = """
        //        IF OBJECT_ID('Users', 'U') IS NULL
        //        CREATE TABLE Users (
        //            Id INT NOT NULL PRIMARY KEY IDENTITY,
        //            FirstName NVARCHAR(MAX),
        //            LastName NVARCHAR(MAX),
        //            ProfileImage NVARCHAR(MAX),
        //            EmailOrPhoneNumber NVARCHAR(MAX),
        //            Company NVARCHAR(MAX),
        //            Department NVARCHAR(MAX),
        //            CompanyOwner BIT,
        //            PasswordHash NVARCHAR(MAX),
        //            Salt NVARCHAR(MAX),
        //            CreatedAt DATETIME,
        //            UpdatedAt DATETIME,
        //            Status INT
        //        );
        //    """;
        //        await connection.ExecuteAsync(sql);
        //    }
        //    async Task _initAccounts()
        //    {
        //        var sql = """
        //        IF OBJECT_ID('Accounts', 'U') IS NULL
        //        CREATE TABLE Accounts (
        //            Id INT NOT NULL PRIMARY KEY IDENTITY,
        //            FirstName NVARCHAR(MAX),
        //            LastName NVARCHAR(MAX),
        //            ProfileImage NVARCHAR(MAX),
        //            EmailOrPhoneNumber NVARCHAR(MAX),
        //            Company NVARCHAR(MAX),
        //            Department NVARCHAR(MAX),
        //            CompanyOwner BIT,
        //            PasswordHash NVARCHAR(MAX),
        //            Salt NVARCHAR(MAX),
        //            CreatedAt DATETIME,
        //            Code NVARCHAR(MAX)
        //        );
        //    """;
        //        await connection.ExecuteAsync(sql);
        //    }
        //    async Task _initCategories()
        //    {
        //        var sql = """
        //            IF OBJECT_ID('Categories', 'U') IS NULL
        //                CREATE TABLE Categories (
        //                    Id INT NOT NULL PRIMARY KEY IDENTITY,
        //                    Name NVARCHAR(MAX),
        //                    Description NVARCHAR(MAX),
        //                    ImagePath NVARCHAR(MAX)
        //                );
        //            """;
        //        await connection.ExecuteAsync(sql);
        //    }
        //    async Task _initProducts()
        //    {
        //        var sql = """
        //            IF OBJECT_ID('Products', 'U') IS NULL
        //                CREATE TABLE Products (
        //                    Id INT NOT NULL PRIMARY KEY IDENTITY,
        //                    Name NVARCHAR(MAX),
        //                    Description NVARCHAR(MAX),
        //                    ImagePath NVARCHAR(MAX),  
        //                    CategoryId INT, 
        //                    IKPUCode NVARCHAR(MAX),
        //                    Number NVARCHAR(MAX),
        //                    Price REAL,
        //                    Status INT,
        //                    PRIMARY KEY(CategoryId, producer)
        //                );
        //            ALTER TABLE Products
        //                ADD CONSTRAINT FK_Category_Products FOREIGN KEY (CategoryId)
        //                REFERENCES Categories(Id);
        //            """;
        //        await connection.ExecuteAsync(sql);
        //    }
        //}
    }
}
