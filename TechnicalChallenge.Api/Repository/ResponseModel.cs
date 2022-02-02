using System;

namespace TechnicalChallenge.Api.Repository
{
    /// <summary>
    /// For speedup coding purpose only - hhandle responnse with entity
    /// </summary>
    public class ResponseModel
    {
        public Guid Id { get; set; }

        public string lessonName { get; set; }
        public string lessonUrl { get; set; }

        public string score { get; set; }

        public string Course { get; set; }
    }
}
