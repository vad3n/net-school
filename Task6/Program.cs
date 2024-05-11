using Task6;

Training training1 = new Training("Training");
training1.Add(new PracticalLesson("Lesson 1", "Task 1", "Solution 1"));
training1.Add(new PracticalLesson("Lesson 2", "Task 2", "Solution 2"));
Console.WriteLine(training1.IsPractical());
training1.Add(new Lecture("Lecture 1", "Topic 1"));
training1.Add(new Lecture("Lecture 2", "Topic 2"));
training1.Add(new Lecture("Lecture 3", "Topic 3"));
training1.Add(new Lecture("Lecture 4", "Topic 4"));
training1.Add(new Lecture("Lecture 5", "Topic 5"));
training1.Add(new Lecture("Lecture 6", "Topic 6"));
training1.Add(new Lecture("Lecture 7", "Topic 7"));
training1.Add(new Lecture("Lecture 8", "Topic 8"));
Console.WriteLine(training1.IsPractical());
Training training2 = (Training)training1.Clone();
training1.Add(new Lecture("Lecture 9", "Topic 9"));
training2.Add(new PracticalLesson("Lesson 3", "Task 3", "Solution 3"));
Console.WriteLine(training2.IsPractical());