using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObjects
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;
        public Time()
        {
            
        }
        public Time(int hour)
        {
            if (hour > 24 || hour < 0)
            {
                this.hour = 0;
            }
            else
            {
                this.hour = hour;
            }
        }
        public Time(int minute, int hour)
        {
            if (hour > 24 || hour < 0)
            {
                this.hour = 0;
            }
            else
            {
                this.hour = hour;
            }
            if (minute > 60 || minute < 0)
            {
                this.minute = 0;
            }
            else
            {
                this.minute = minute;
            }
        }
        public Time(int hour, int minute, int second)
        {
            if (hour > 24 || hour < 0)
            {
                this.hour = 0;
            }
            else
            {
                this.hour = hour;
            }
            if (minute > 60 || minute < 0)
            {
                this.minute = 0;
            }
            else
            {
                this.minute = minute;
            }
            if (second > 60 || second < 0)
            {
                this.second = 0;
            }
            else
            {
                this.second = second;
            }
        }
        public string GetTime()
        {
            string getHour = ($"{hour}");
            if (hour < 10)
            {
                getHour = ($"0{hour}");
            }
            string getMinute = ($"{minute}");
            if (minute < 10)
            {
                getMinute = ($"0{minute}");
            }
            string getSecond = ($"{second}");
            if (second < 10)
            {
                getSecond = ($"0{second}");
            }
            string getTime = ($"{getHour}:{getMinute}:{getSecond}");
            return getTime;
        }
        public void SetHour(int hour)
        {
            if (hour >= 24 || hour < 0)
            {
                return;
            }
            this.hour = hour;
        }
        public void SetMinute(int minute)
        {
            if (minute >= 60 || minute < 0)
            {
                return;
            }
            this.minute = minute;
        }
        public void SetSecond(int second)
        {
            if (second >= 60 || second < 0)
            {
                return;
            }
            this.second = second;
        }
        public int GetHour()
        {
            return hour;
        }
        public int GetMinute()
        {
            return minute;
        }
        public int GetSecond()
        {
            return second;
        }
        public void AddSecond(int addValueSecond)
        {
            int resultSecond = second + addValueSecond; 
            int value = resultSecond / 60; 
            if (resultSecond >= 60)
            {
                second = resultSecond % 60;
            }
            if (resultSecond < 60)
            {
                second = resultSecond;
            }
            AddMinute(value);
        }
        public void AddMinute(int addValueMinute) 
        {
            int resultMinute = minute + addValueMinute; 
            int value = resultMinute / 60;
            if (resultMinute >= 60)
            {
                minute = resultMinute % 60;
            }
            if (resultMinute < 60)
            {
                minute = resultMinute;
            }
            AddHour(value);
        }
        public void AddHour(int addValueHour) 
        {
            int addHour = hour + addValueHour;
            if (addHour >= 24)
            {
                hour = addHour % 24;
            }
            if (addHour < 24)
            {
                hour = addHour;
            }
        }
    }
}
