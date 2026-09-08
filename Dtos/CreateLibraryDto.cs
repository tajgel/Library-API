namespace Library.Api.Dtos;

public record CreateLibraryDto(
    string Name,
    string Genre,
    int Price,
    DateOnly ReleaseDate
);