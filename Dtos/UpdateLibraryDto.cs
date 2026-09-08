namespace Library.Api.Dtos;

public record UpdateLibraryDto
(
    string Name,
    string Genre,
    int Price,
    DateOnly ReleaseDate
);