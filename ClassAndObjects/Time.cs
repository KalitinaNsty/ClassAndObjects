﻿using System;
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
            this.hour = hour;
        }
        public Time(int minute, int hour)
        {
            this.hour = hour;
            this.minute = minute;
        }
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
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
            if (hour >= 0 && hour > 24)
            {
                return;
            }
            this.hour = hour;
        }
        public void SetMinute(int minute)
        {
            if (minute <= 0 && minute > 60)
            {
                return;
            }
            this.minute = minute;
        }
        public void SetSecond(int second)
        {
            if (second >= 0 && second > 60)
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