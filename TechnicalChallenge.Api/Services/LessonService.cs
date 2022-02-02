using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TechnicalChallenge.Api.Repository;

namespace TechnicalChallenge.Api.Services
{
    /// <summary>
    /// Lesson service to implement request
    /// </summary>
    public class LessonService : ILessonService
    {
        private readonly DataBaseContext _dataBaseContext;

        public LessonService(DataBaseContext dataBaseContext)
        {
            this._dataBaseContext = dataBaseContext;
        }

        public async Task<ResponseModel> GetLessonByUserAndLessonId(string userId, string lessonId)
        {
            //var result = await (from LS in _dataBaseContext.Lessons
            //              join TL in _dataBaseContext.TrackingLogs on LS.Id equals TL.Id
            //              join CR in _dataBaseContext.Courses on LS.Id equals CR.Id
            //              where LS.Id.ToString() == lessonId && TL.userId == userId
            //              select new
            //              {
            //                  Id = LS.Id,
            //                  lessonName = LS.Name,
            //                  lesonUrl = LS.lessonUrl,
            //                  score = TL.score,
            //                  course = CR.Name
            //              }).ToListAsync();

            //Need to be refactored to for better handling
            var lesson = await _dataBaseContext.Lessons.FirstAsync(lesson => lesson.Id.ToString() == lessonId);
            var tracklog = await _dataBaseContext.TrackingLogs.FirstAsync(log => log.LessonId.ToString() == lessonId && log.userId == userId);
            var course = await _dataBaseContext.Courses.FirstAsync(course => course.Id == tracklog.CourseId);

            var result = new ResponseModel
            {
                Id = lesson.Id,
                lessonName = lesson.Name,
                lessonUrl = lesson.lessonUrl,
                score = tracklog.score.ToString(),
                Course = course.Name
            };
            return result;

        }
    }
}
