using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a quiz
/// </summary>
public class Quiz
{
	// State
	private string _studentName;
	private int _total;
	private int _mark;
	private int _weight;

	// Behaviour

	/// <summary>
	/// Represents the quiz total
	/// </summary>
	public int Total
	{
		get
		{
			return _total;
		}
	}

	/// <summary>
	/// Represents the quiz weight
	/// </summary>
	public int Weight
	{
		get
		{
			return _weight;
		}
	}

	/// <summary>
	/// Represents the mark for the quiz. The mark must be between
	/// zero and the quiz total.
	/// </summary>
	public int Mark
	{
		get
		{
			return _mark;
		}

		set
		{
			if (value < 0 || value > Total)
			{
				throw new Exception($"Mark must be between 0 and {Total}");
			}

			_mark = value;
		}
	}

	/// <summary>
	/// Represents the name of the student that owns the quiz. The 
	/// student name cannot be empty.
	/// </summary>
	public string StudentName
	{
		get
		{
			return _studentName;
		}

		set
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new Exception("Student name cannot be empty");
			}

			_studentName = value;
		}
	}

	/// <summary>
	/// Represents the percentage earned on the quiz
	/// </summary>
	public int Percentage
	{
		get
		{
			return (int)(((double)Mark / Total) * 100);
		}
	}

	/// <summary>
	/// Creates a new quiz instance
	/// </summary>
	/// <param name="total">The quiz total marks</param>
	/// <param name="weight">The weight for the course</param>
	/// <exception cref="Exception">If the total is less than 1 or the 
	/// weight is less than 0</exception>
	public Quiz(int total, int weight)
	{
		if (total < 1)
		{
			throw new Exception("Total must be positive");
		}

		if (weight < 0)
		{
			throw new Exception("Weight must be zero or greater");
		}

		_studentName = "";
		_total = total;
		_weight = weight;
	}
}