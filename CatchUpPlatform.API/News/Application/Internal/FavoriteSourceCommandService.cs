using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.News.Domain.Services;

namespace CatchUpPlatform.API.News.Application.Internal
{
    public class FavoriteSourceCommandService : IFavoriteSourceCommandService
    {
        Task<IFavoriteSourceCommandService?> IFavoriteSourceCommandService.Handle(CreateFavoriteSource command)
        {
            throw new NotImplementedException();
        }
    }
}
