using System;
					
public class Program
{
    // calling ExamGrader class
	public ExamGrader myGrade;
	
	public void Main()
	{
        // establishing that myGrade is connected to ExamGrader class and executing the function ExamScore within that class
		myGrade = new ExamGrader();
		myGrade.ExamScore();
	}
	
}
public class ExamGrader {
	
    // values for switch statement
	public enum Grades {
		A,
		B,
		C,
		D,
		F
	}
	
    // establishing finalGrade
	public Grades finalGrade = Grades.A;
	
    // ExamScore function
	public void ExamScore() {
		
        // asking user for input and using converted input as scoreInput variable
		Console.WriteLine("What percentage did you score on your exam?");
		int scoreInput = Convert.ToInt32(Console.ReadLine());

		// establishing grade value ranges and assigning corresponding grade with if statement
		if (scoreInput >= 90) {
			finalGrade = Grades.A;
		} else if (scoreInput <= 89 && scoreInput >= 80) {
			finalGrade = Grades.B;
		} else if (scoreInput <= 79 && scoreInput >= 70) {
			finalGrade = Grades.C;
		} else if (scoreInput <= 69 && scoreInput >= 60) {
			finalGrade = Grades.D;
		} else if (scoreInput <= 59 && scoreInput >= 0) {
			finalGrade = Grades.F;
		}
		
        // using switch statement to write the appropriate message for the appropriate grade
		switch (finalGrade) {
			case Grades.A:
				Console.WriteLine("Your grade is an A.");
				break;
			case Grades.B:
				Console.WriteLine("Your grade is a B.");
				break;
			case Grades.C:
				Console.WriteLine("Your grade is a C.");
				break;
			case Grades.D:
				Console.WriteLine("Your grade is a D.");
				break;
			case Grades.F:
				Console.WriteLine("Your grade is a F.");
				break;
		}
	}
}