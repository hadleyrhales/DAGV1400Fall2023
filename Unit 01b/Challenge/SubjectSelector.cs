using System;
					
public class Program
{
    // calling ExamGrader class
	public ExamGrader myGrade;
	public SubjectSelect mySubject;
	
	public void Main()
	{
        // establishing that myGrade is connected to ExamGrader class and executing the function ExamScore within that class
		myGrade = new ExamGrader();
		myGrade.ExamScore();
		mySubject = new SubjectSelect();
		mySubject.SubjectSurvey();
	}
	
}
public class ExamGrader {
	
    // values for finalGrade switch statement
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
		
        // using finalGrade switch statement to write the appropriate message for the appropriate grade
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

public class SubjectSelect {
	
	// values for switch statement
	public enum Subjects {
		Math,
		English,
		History,
		Science,
		Music,
		Art
	}
	
	// establishing favSubject
	public Subjects faveSubject = Subjects.Math;
	
	// SubjectSurvey function
	public void SubjectSurvey() {
		
		// asking user for input and using that input as the subjectInput variable
		Console.WriteLine("What is your favorite subject?");
		string subjectInput = Console.ReadLine();
		
		// establishing possible subject inputs and changing faveSubject with if statement
		if (subjectInput == "Math" || subjectInput == "math"){
			faveSubject = Subjects.Math;
		} else if (subjectInput == "English" || subjectInput == "english"){
			faveSubject = Subjects.English;
		} else if (subjectInput == "History" || subjectInput == "history"){
			faveSubject = Subjects.History;
		} else if (subjectInput == "Science" || subjectInput == "science"){
			faveSubject = Subjects.Science;
		} else if (subjectInput == "Music" || subjectInput == "music"){
			faveSubject = Subjects.Music;
		} else if (subjectInput == "Art" || subjectInput == "art"){
			faveSubject = Subjects.Art;
		}
		
		// using faveSubject switch statement to write the correct message for the corresponding subject
		switch (faveSubject) {
			case Subjects.Math:
				Console.WriteLine("Don't give up on your love for Mathematics! As you practice, explore, and push yourself, you'll see the incredible progress you have made.");
				break;
			case Subjects.English:
				Console.WriteLine("Keep pursuing your passion for English! Whether it's reading, writing or analyzing literature, it's a subject that can expand your mind and encourage creative thinking.");
				break;
			case Subjects.History:
				Console.WriteLine("It's amazing that you're interested in History! By studying the past, you can gain an understanding of how societies functioned and how they have evolved over time.");
				break;
			case Subjects.Science:
				Console.WriteLine("Science is really cool! Don't be afraid to embrace the challenge of understanding complex theories and conducting experiments.");
				break;
			case Subjects.Music:
				Console.WriteLine("It's good to have Music in your life! It can transcend time and cultures, and has the ability to bring joy and inspiration to both yourself and others.");
				break;
			case Subjects.Art:
				Console.WriteLine("By pursuing Art, you're opening up a world of creativity and expression that can connect with people on an emotional level. Never give up on that.");
				break;
		}
	}
}