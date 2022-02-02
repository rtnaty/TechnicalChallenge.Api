using System;

namespace TechnicalChallenge.Api.Repository
{
    //Lesson model
    public class LessonModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string lessonUrl { get; set; }

        public Guid courseId { get; set; }

    }
}
