using System;
using System.Collections.Generic;

namespace Courses
{
    public class Courses
    {
        SortedList<string, Course> sortedList = new SortedList<string, Course>();

        public Courses()
        {
            Course thisCourse;
            Schedule thisSchedule;
            Random rand = new Random();

            for (int i = 200; i < 300; ++i)
            {
                thisCourse = new Course($"IGME-{i}", $"Description for IGME-{i}");
                thisSchedule = new Schedule();

                for (int dow = 0; dow < 7; ++dow)
                {
                    if (rand.Next(0, 2) == 1)
                    {
                        thisSchedule.DaysOfWeek.Add((DayOfWeek)dow);
                        int nHour = rand.Next(0, 24);
                        thisSchedule.StartTime = new DateTime(1, 1, 1, nHour, 0, 0);
                        thisSchedule.EndTime = new DateTime(1, 1, 1, nHour, 50, 0);
                    }
                }

                thisCourse.CourseSchedule = thisSchedule;
                this[thisCourse.CourseCode] = thisCourse;
            }
        }

        public Course this[string courseCode]
        {
            get
            {
                Course returnVal;
                try
                {
                    returnVal = sortedList[courseCode];
                }
                catch
                {
                    returnVal = null;
                }

                return returnVal;
            }

            set
            {
                try
                {
                    sortedList[courseCode] = value;
                }
                catch
                {
                    // Handle exceptions for duplicate key, if needed
                }
            }
        }

        public void Remove(string courseCode)
        {
            if (sortedList.ContainsKey(courseCode))
            {
                sortedList.Remove(courseCode);
            }
        }
    }

    public class Course
    {
        public string CourseCode;
        public string Description;
        public string TeacherEmail;
        public Schedule CourseSchedule;

        public Course(string courseCode, string description)
        {
            CourseCode = courseCode;
            Description = description;
        }
    }

    public class Schedule
    {
        public DateTime StartTime;
        public DateTime EndTime;
        public List<DayOfWeek> DaysOfWeek;

        public Schedule()
        {
            DaysOfWeek = new List<DayOfWeek>();
        }
    }
}
