using System;
using System.Collections.Generic;
using System.Text;

namespace MobApplication.Model
{
    public class ActivityLogGroup : List<ActivityLog>
    {
        public string Title { get; set; }
        public ActivityLogGroup(string name, List<ActivityLog> List) : base(List)
        {
            Title = name;
        }
       // public List<ActivityLog> List { get; set; }


    }
}
