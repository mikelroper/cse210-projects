using System;
using System.Collections.Generic;
using System.Linq;
class Time
{
    private DateTime startHour { get; set; }
    private DateTime stopHour { get; set; }
    private TimeSpan timeLogged { get; set; }

    public void LogStartTime()
    {
        startHour = DateTime.Now;
    }

    public void LogEndTime()
    {
        stopHour = DateTime.Now;
    }

    public TimeSpan TimeLogged()
    {
        timeLogged = (stopHour - startHour);
        return timeLogged;
    }
// add user name to to the time entry for saving.


}
