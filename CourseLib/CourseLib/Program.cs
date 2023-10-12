using System.Collections.Generic;

namespace CourseLib
{
        public class Courses
        {
            SortedList<string, Course> sortedList = new SortedList<string, Course>();

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
        }

        public class Course
        {
            // Define properties and methods for the Course class, if needed
        }
    }


