using CLRL.Domain.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLRL.Infrastructure.Configurations;

internal sealed class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("books");

        builder.HasKey(book => book.Id);

        builder.OwnsOne(book => book.Title);

        builder.OwnsOne(book => book.Title);

        builder.OwnsOne(book => book.FirstName);

        builder.OwnsOne(book => book.LastName);

        builder.OwnsOne(book => book.TotalCopies);

        builder.OwnsOne(book => book.UsedCopies);

        builder.OwnsOne(book => book.Type);

        builder.OwnsOne(book => book.ISBN);

        builder.OwnsOne(book => book.Category);

        builder.Property<uint>("Version").IsRowVersion();
    }
}
