using System;

namespace TechnicalChallenge.Api.Repository
{
    /// <summary>
    /// tracking log model
    /// </summary>
    public class TrackingLogModel
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid LessonId { get; set; }

        public string userId { get; set; }
        public int score { get; set; }

    }
}