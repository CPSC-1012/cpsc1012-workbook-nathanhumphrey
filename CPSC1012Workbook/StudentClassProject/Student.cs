using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

	/// <summary>
	/// The student's first name
	/// </summary>
	public string FirstName
	{
		get
		{
			return _firstName;
		}

		set
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new Exception("First name cannot be empty");
			}

			_firstName = value.Trim();

		}
	}

	// COMPLETE: Implement LastName property, cannot be empty or white space
	/// <summary>
	/// The student's last name
	/// </summary>
	public string LastName
	{
		get
		{
			return _lastName;
		}

		set
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new Exception("Last name cannot be empty");
			}

			_lastName = value.Trim();

		}
	}

	// COMPLETE: Implement StudentId property, must be positive four-digit
	/// <summary>
	/// The student's Id
	/// </summary>
	public int StudentId
	{
		get
		{
			return _studentId;
		}

		set
		{
			if (value < 1000 || value > 9999)
			{
				throw new Exception("Student id must be positive and four digits");
			}

			_studentId = value;
		}
	}

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

		// COMPLETE: use the properties for LastName and StudentId
		//		 to assign remaining params
		LastName = lastName;
		StudentId = studentId;
	}

	/*
	Method implementation for FullName
	/// <summary>
	/// Returns the student's full name
	/// </summary>
	/// <returns>Return "FirstName LastName"</returns>
	public string FullName()
	{
		return $"{FirstName} {LastName}";
	}
	*/

	// Property implementation for FullName

	/// <summary>
	/// The student's full name
	/// </summary>
	public string FullName
	{
		get
		{
			return $"{FirstName} {LastName}";
		}
	}

	/// <summary>
	/// Returns the CSV representation of the student
	/// </summary>
	/// <returns>Returns "FirstName,LastName,StudentId"</returns>
	public string ToCsvString()
	{
		return $"{FirstName},{LastName},{StudentId}";
	}
}