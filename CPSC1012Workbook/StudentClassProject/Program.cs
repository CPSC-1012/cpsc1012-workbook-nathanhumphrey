// Declare variables for our students
Student jane = new Student();
// TODO: create the clark student using the greedy constructor
Student clark = new Student();

// TODO: Assign jane remaining fields
jane.FirstName = "Jane";
//jane.lastName = "Doe";
//jane.studentId = 1234;

Console.WriteLine($"{jane.FullName()} has id {jane.StudentId}");
Console.WriteLine($"{clark.FullName()} has id {clark.StudentId}");

/// <summary>
/// Represents a student
/// </summary>
class Student
{
	// Fields
	private string _firstName;
	private string _lastName;
	private int _studentId;

	// Methods

	// Getter and setter for firstName
	//public string GetFirstName()
	//{
	//	return _firstName;
	//}

	//public void SetFirstName(string firstName)
	//{
	//	if (!string.IsNullOrWhiteSpace(firstName)) 
	//	{
	//		_firstName = firstName.Trim();
	//	}
	//}

	// C# property for firstName
	public string FirstName
	{
		get
		{
			return _firstName;
		}

		set
		{
			if (!string.IsNullOrWhiteSpace(value))
			{
				_firstName = value.Trim();
			}
			else
			{
				throw new Exception("First name cannot be empty");
			}
			
		}
	}

	// TODO: Implement LastName property, cannot be empty or white space

	// TODO: Implement StudentId property, must be positive four-digit

	/// <summary>
	/// Creates a default student with empty first and last names, and 
	/// student id of zero.
	/// </summary>
	public Student()
	{
		_firstName = "";
		_lastName = "";
		_studentId = 0;
	}

	/// <summary>
	/// Creates a student with the supplied first name, last name, and id
	/// </summary>
	/// <param name="firstName">the student first name</param>
	/// <param name="lastName">the student last name</param>
	/// <param name="studentId">the student id</param>
	public Student(string firstName, string lastName, int studentId)
	{
		// Leverage the properties for validation
		FirstName = firstName;

		// TODO: use the properties for LastName and StudentId
		//		 to assign remaining params
	}

	/// <summary>
	/// Returns the student's full name
	/// </summary>
	/// <returns>Return "FirstName LastName"</returns>
	public string FullName()
	{
		return $"{FirstName} {LastName}";
	}
}