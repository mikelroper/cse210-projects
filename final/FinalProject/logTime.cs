using System;
using System.Collections.Generic;
using System.Linq;
class Time
{
    private DateTime startHour;
    private DateTime stopHour;
    private TimeSpan timeLogged;

    public void LogStartTime()
    {
        startHour = DateTime.Now;
    }

    public void LogEndTime()
    {
        stopHour = DateTime.Now;
    }

    public TimeSpan ViewTime()
    {
        timeLogged = (stopHour - startHour);
        return timeLogged;
    }

    

}
