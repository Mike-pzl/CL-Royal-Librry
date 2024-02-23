using CLRL.Application.Abstractions.Data;
using Dapper;
using System.Data;

namespace CLRL.API.Extensions;

internal static class SeedDataExtensions
{
    public static void SeedData(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        ISqlConnectionFactory sqlConnectionFactory = scope.ServiceProvider.GetRequiredService<ISqlConnectionFactory>();
        using IDbConnection connection = sqlConnectionFactory.CreateConnection();

        string sql = @$"
INSERT INTO books (id, title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'Pride and Prejudice', 'Jane', 'Austen', 100, 80, 'Hardcover', '1234567891', 'Fiction');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'To Kill a Mockingbird', 'Harper', 'Lee', 75, 65, 'Paperback', '1234567892', 'Fiction');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'The Catcher in the Rye', 'J.D.', 'Salinger', 50, 45, 'Hardcover', '1234567893', 'Fiction');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'The Great Gatsby', 'F. Scott', 'Fitzgerald', 50, 22, 'Hardcover', '1234567894', 'Non-Fiction');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'The Alchemist', 'Paulo', 'Coelho', 50, 35, 'Hardcover', '1234567895', 'Biography');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'The Book Thief', 'Markus', 'Zusak', 75, 11, 'Hardcover', '1234567896', 'Mystery');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'The Chronicles of Narnia', 'C.S.', 'Lewis', 100, 14, 'Paperback', '1234567897', 'Sci-Fi');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'The Da Vinci Code', 'Dan', 'Brown', 50, 40, 'Paperback', '1234567898', 'Sci-Fi');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'The Grapes of Wrath', 'John', 'Steinbeck', 50, 35, 'Hardcover', '1234567899', 'Fiction');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'The Hitchhiker''s Guide to the Galaxy', 'Douglas', 'Adams', 50, 35, 'Paperback', '1234567900', 'Non-Fiction');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'Moby-Dick', 'Herman', 'Melville', 30, 8, 'Hardcover', '8901234567', 'Fiction');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'To Kill a Mockingbird', 'Harper', 'Lee', 20, 0, 'Paperback', '9012345678', 'Non-Fiction');


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('{new Guid()}', 'The Catcher in the Rye', 'J.D.', 'Salinger', 10, 1, 'Hardcover', '0123456789', 'Non-Fiction');";

        connection.Execute(sql);
    }
}
