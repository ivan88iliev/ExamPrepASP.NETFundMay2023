using Library.Models;

namespace Library.Contracts
{
    public interface IBookService
    {
        Task AddBookAsynck(AddBookViewModel model);
        Task AddBookToCollectionAsync(string userId, BookViewModel book);
        Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync();
        Task<BookViewModel?> GetBookByIdAsync(int id);
        Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId);
        Task<AddBookViewModel> GetNewAddBookModelAsync();
        Task RemoveBookFromCollectionAsync(string userId, BookViewModel book);
    }
}
