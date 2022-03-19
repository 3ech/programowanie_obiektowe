using System;

namespace labolatorium222
{ 
    public class Program
    {
        public class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public bool Equals(Person? other)
            {
                if (other == null) return false;
                if (other == this) return true;
                return object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
            } 
        }
        public class Teacher
        {
            private string name;
            private int age;
        }
        enum TaskStatus
        {
            Waiting,
            Progress,
            Done,
            Rejected
        }
        public class Task
        {
            private string name;
            private TaskStatus Status;

        }
        public class Student
        {
            private Task tasks;
            public string group
            {
              get { return name; }
              set { name = value; }
            }
        }
       public class Classroom
        {
            public string name;
            
        }
        public static void Main()
        {
            Teacher treacher = new Teacher("Maria Skłodowska", 50);

            Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student3 = new Student("Jaś Fasola", 23, "LAB-02");

            student1.AddTask("Taks A", TaskStatus.Waiting);
            student1.AddTask("Taks B", TaskStatus.Waiting);
            student1.AddTask("Taks C", TaskStatus.Rejected);

            student2.AddTask("Taks A", TaskStatus.Waiting);
            student2.AddTask("Taks B", TaskStatus.Waiting);
            student2.AddTask("Taks C", TaskStatus.Rejected);

            student3.AddTask("Taks D", TaskStatus.Done);
            student3.AddTask("Taks E", TaskStatus.Waiting);
            student3.AddTask("Taks F", TaskStatus.Waiting);

            student3.UpdateTask(1, TaskStatus.Done);
            student3.UpdateTask(2, TaskStatus.Progress);

            Person[] persons = { treacher, student1, student2, student3 };
            Classroom classroom = new Classroom("Sala Komputerowa", persons);

            Console.WriteLine(classroom);

            Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
            Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false
        }
    }
}