using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceCapacity : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }

    public class TaskContainer : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class TaskFilterValue : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class TaskLocked : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class Appointment : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class AppointmentCategory : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class AppointmentImportance : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class AppointmentLocked : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class AppointmentPlanningQuantity : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class AppointmentUri : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class Resource : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class ResourceCertificate : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class ResourceFilterValue : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class ResourceGpsTracking : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }
    public class ResourceUri : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new NotImplementedException();
        }
    }


    public class ResourceCalendar : IImportRequestable
    {
        public string Code { get; set; }

        public string ResourceNo { get; set; }

        public string CalendarCode { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ImportRequest ToImportRequest()
            => new ImportRequest(
                "mboc_upsertFilterGroup",
                new List<string> { "ResourceCalendarCode", "ResourceNo", "CalendarCode", "StartDate", "EndDate" }.ToArray(),
                new List<string> { Code, ResourceNo, CalendarCode, StartDate.ToString("s"), EndDate.ToString("s") }.ToArray());
    }
}