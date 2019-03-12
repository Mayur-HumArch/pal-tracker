using Microsoft.AspNetCore.Mvc;
using System;

namespace PalTracker
{

   

        [Route("/")]
        public class TimeEntryController : ControllerBase
        {
            

            private readonly TimeEntry _timesheet;
     

            [HttpGet]
            public long? Id() => _timesheet.Id;
            public long? ProjectId() => _timesheet.ProjectId;
            public long? UserId() => _timesheet.UserId;
            public DateTime  Date() => _timesheet.Date;
            public int Hours() => _timesheet.Hours;


            public TimeEntryContoller(TimeEntry timesheet)
            {
                 try{
                
                   _timesheet.Id = timesheet.Id;
                   _timesheet.ProjectId = timesheet.ProjectId;
                   _timesheet.UserId = timesheet.UserId;
                   _timesheet.Date = timesheet.Date ;
                   _timesheet.Hours = timesheet.Hours;
                   

                 }
                   catch{
                    throw new NotImplementedException();
                        }

            }
    }
}
 
    
    

