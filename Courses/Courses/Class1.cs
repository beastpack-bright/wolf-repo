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

            // Generate courses IGME-200 through IGME-299
            for (int i = 200; i < 300; ++i)
            {
                // Use constructor to create a new course object with code and description
                thisCourse = new Course($"IGME-{i}", $"Description for IGME-{i}");

                // Create a new Schedule object
                thisSchedule = new Schedule();

                for (int dow = 0; dow < 7; ++dow)
                {
                    // 50% chance of the class being on this day of the week
                    if (rand.Next(0, 2) == 1)
                    {
                        // Add to the daysOfWeek list
                        thisSchedule.DaysOfWeek.Add((DayOfWeek)dow);

                        // Select a random hour of the day
                        int nHour = rand.Next(0, 24);

                        // Set start and end times with a minute duration
                        // Select a fixed date to allow time calculations
                        thisSchedule.StartTime = new DateTime(1, 1, 1, nHour, 0, 0);
                        thisSchedule.EndTime = new DateTime(1, 1, 1, nHour, 50, 0);
                    }
                }

                // Set the schedule for this course
                thisCourse.CourseSchedule = thisSchedule;

                // Add this course to the SortedList
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
        public string CourseCode { get; set; }
        public string Description { get; set; }
        public string TeacherEmail { get; set; }
        public Schedule CourseSchedule { get; set; }

        public Course(string courseCode, string description)
        {
            CourseCode = courseCode;
            Description = description;
        }
    }

    public class Schedule
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<DayOfWeek> DaysOfWeek { get; set; }

        public Schedule()
        {
            DaysOfWeek = new List<DayOfWeek>();
        }
    }
}
