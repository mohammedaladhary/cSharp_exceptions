namespace Exceptions
{
    internal class Student
    {
        public string studentName { get; set; }
        public string studentId { get; set; }
        int age { get; set; }

        public Student(string studentName, string studentId, int age)
        {
            this.studentName = studentName;
            this.studentId = studentId;
            this.age = age;
        }

        public static Boolean validateStudents(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].studentId == students[j].studentId)
                    {
                        //throw new ApplicationException("ERROR: " + students[i].studentName + 
                        //    " has the same studentID with: "+ students[j].studentName);
                        throw new SameRegistrationNumberException(students[i], students[j]);
                    }
                }
            }
            return true;
        }
    }
}