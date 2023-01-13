using API.Entities;
using API.Interfaces;

namespace API.DTOs
{
    public class LikesRepository : ILikesRepository
    {
        public Task<UserLike> GetUserLike(int sourcUserId, int targetUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LikeDto>> GetUserLikes(string predicate, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserWithLike(int userId)
        {
            throw new NotImplementedException();
        }
    }
}