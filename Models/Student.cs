namespace StudentManagementSystem.Models
{
	class Student
	{
		private string name;
		private int age;
		private string grade;

		public Student(string name, int age, string grade)
		{
			this.name = name;
			this.age = age;
			this.grade = grade;
		}

		public string Name { get { return name; } }
		public int Age { get { return age; } }
		public string Grade { get { return grade; } }

		public void PrintInfo()
		{
			Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
		}
	}
}