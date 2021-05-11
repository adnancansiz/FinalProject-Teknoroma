using DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Issue:BaseEntity
    {

        public string Subject { get; set; }
        public string Problem { get; set; }
        public string Answer { get; set; }


        public IssueStatus IssueStatus { get; set; }

        public AppUser AppUser { get; set; }
        public Guid AppUserId { get; set; }

    }
}
