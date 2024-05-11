namespace Task6
{
    public class PracticalLesson : Entity
    {
        public string? TaskConditionLink { get; set; }
        public string? SolutionLink { get; set; }

        public PracticalLesson()
        {

        }

        public PracticalLesson(string? description, string? taskConditionLink, string? solutionLink) : base(description)
        {
            TaskConditionLink = taskConditionLink;
            SolutionLink = solutionLink;
        }
    }
}
