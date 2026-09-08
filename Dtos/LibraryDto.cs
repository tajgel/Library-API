namespace Library.Api.Dtos;

public record LibraryDto(
    int Id,
    string Name,
    string Genre,
    int Price,
    DateOnly ReleaseDate
);