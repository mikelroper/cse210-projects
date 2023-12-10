using System;
using System.Collections.Generic;
using System.Linq;
class Time
{
    private DateTime startHour { get; set; }
    private DateTime stopHour { get; set; }
    private TimeSpan timeLogged { get; set; }
    private string userName { get; set; }
    private string timeType {get; set;}


    public class TimeLog
    {
        public string UserName { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime StopHour { get; set; }
        public string TimeType { get; set; }
        public TimeSpan TimeLogged { get; set; }
    }


    public void LogStartTime(string displayName)
    {
        userName = displayName;
        startHour = DateTime.Now;
        timeType = "start";

        List<TimeLog> timeLogs = new List<TimeLog>();

        TimeLog currentTimeLog = GetCurrentTimeLog(userName);
        timeLogs.Add(currentTimeLog);

        SaveUserToFile.SaveTimeToJson(timeLogs);
    }

    public DateTime GetStartHour()
    {
        return startHour;
    }

    public void LogEndTime(string displayName)
    {
        userName = displayName;
        stopHour = DateTime.Now;
        timeType = "stop";

        List<TimeLog> timeLogs = new List<TimeLog>();

        TimeLog currentTimeLog = GetCurrentTimeLog(userName);
        timeLogs.Add(currentTimeLog);

        SaveUserToFile.SaveTimeToJson(timeLogs);
    }

    public DateTime GetStopHour()
    {
        return stopHour;
    }

    public TimeSpan TimeLogged()
    {
        timeLogged = (stopHour - startHour);
        return timeLogged;
    }

    public TimeLog GetCurrentTimeLog(string displayName)
    {
        TimeLog timeLog = new TimeLog
        {
            UserName = displayName,
            StartHour = startHour,
            StopHour = stopHour,
            TimeType = timeType,
            TimeLogged = timeLogged
        };
        return timeLog;
    }

    

}
