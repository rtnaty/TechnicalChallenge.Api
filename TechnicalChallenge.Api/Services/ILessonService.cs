using System.Threading.Tasks;
using TechnicalChallenge.Api.Repository;

namespace TechnicalChallenge.Api.Services
{
    public interface ILessonService
    {
        Task<ResponseModel> GetLessonByUserAndLessonId(string userId, string lessonId);
    }
}