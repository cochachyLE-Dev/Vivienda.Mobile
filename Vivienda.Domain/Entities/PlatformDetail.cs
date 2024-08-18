using Vivienda.Domain.Entities.Shared;
using System.Collections.Generic;

namespace Vivienda.Domain.Entities
{
    public class PlatformDetail
    {
        public Dictionary<string, string> Questions { get; set; }
        public List<Comment> Comments { get; set; }
        public int TotalRating { get; set; }        
        public List<RatingDetail> RatingDetails { get; set; }
    }    
}