using CatchUpPlatform.API.News.Domain.Model.Commands;

namespace CatchUpPlatform.API.News.Domain.Services
{
    public interface IFavoriteSourceCommandService {
        Task<IFavoriteSourceCommandService?> Handle(CreateFavoriteSource command);
    
}
}
