using System.Data.SqlClient;

class DatabaseHelper
{
	private string connectionString = "Server=.;Database=StudentDB;Trusted_Connection=True;";

	public void AddStudentToDB(string name, int age, string grade)
	{
		// هنا بعدين هتحط الكود اللي ينادي الـ Stored Procedure
	}

	public void GetStudentsFromDB()
	{
		// هنا بعدين هتحط الكود اللي يجيب كل الطلاب من الداتا بيز
	}
}