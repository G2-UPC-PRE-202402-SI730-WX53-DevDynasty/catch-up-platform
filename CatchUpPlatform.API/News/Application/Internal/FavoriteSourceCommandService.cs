using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.News.Domain.Services;

namespace CatchUpPlatform.API.News.Application.Internal
{
    public class FavoriteSourceCommandService : IFavoriteSourceCommandService
    {
        public Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand command)
        {
            throw new NotImplementedException();
        }
        public Task<FavoriteSource?> Handle(DeleteFavoriteSourceCommand command)
        {
            throw new NotImplementedException();
        }
        public Task<FavoriteSource?> Handle(UpdateFavoriteSourceCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
