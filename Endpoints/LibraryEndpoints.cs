using Library.Api.Dtos;

namespace Library.Api.Endpoints;

public class LibraryEndpoints
{
    private static readonly List<LibraryDto> LibraryList =
    [
        new(
            1,
            "Berserk",
            "Shonen",
            29,
            new DateOnly(1989, 8, 29)
        ),
        new(
            2,
            "Bleach",
            "Shonen",
            29,
            new DateOnly(2004, 6, 6)
        )
    ];

    public static void MapLibraryEndpoints(WebApplication app)
    {
        var library = app.MapGroup("/library");
        library.MapGet("{id}", (int id) =>
        {
            return Results.Ok(LibraryList.Find(game => game.Id == id));
        }).WithName("GetLibrary");
        library.MapPost("/", (CreateLibraryDto dto) =>
        {
            LibraryList.Add(new(
                LibraryList.Count+1,
                dto.Name,
                dto.Genre,
                dto.Price,
                dto.ReleaseDate
                ));
            return Results.Ok();
        });
        library.MapPut("{id}", (int id, UpdateLibraryDto updatedLibrary) =>
        {
            int index = LibraryList.FindIndex(game => game.Id == id);
            LibraryList[index] = new(
                    id,
                    updatedLibrary.Name,
                    updatedLibrary.Genre,
                    updatedLibrary.Price,
                    updatedLibrary.ReleaseDate
                );
            return Results.NoContent();
        });
        library.MapDelete("{id}", (int id) =>
        {
            int index = LibraryList.FindIndex(game => game.Id == id);
            LibraryList.Remove(LibraryList[index]);
            return Results.NoContent();
        });
    }
}