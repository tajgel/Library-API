using System.ComponentModel.DataAnnotations;

namespace Library.Api.Dtos;

public record UpdateLibraryDto
(
    [Required][StringLength(50)]string Name,
    [Required][StringLength(20)]string Genre,
    [Required][Range(1, 6767)]int Price,
    [Required]DateOnly ReleaseDate
);