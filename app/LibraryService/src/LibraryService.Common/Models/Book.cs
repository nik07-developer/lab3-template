using Common.Models.Enums;

namespace LibraryService.Common.Models;

public class Book
{
    public int Id { get; set; }
    public Guid BookUid { get; set; } // Для uuid используем Guid
    public string Name { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public BookCondition Condition { get; set; }

    // Связь один-ко-многим с таблицей LibraryBooks
    public List<LibraryBooks> LibraryBooks { get; set; }
}