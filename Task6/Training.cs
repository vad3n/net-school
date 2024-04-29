using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Training
    {
        private Entity[] _set = new Entity[10];
        private int _count = 0;

        public string? Description { get; set; }

        public Training(string? description)
        {
            Description = description;
        }

        public Training Clone()
        {
            Training result = new Training(Description);

            for (int i = 0; i < _count; i++)
            {
                if (_set[i] is Lecture lecture)
                {
                    result.Add(new Lecture(lecture.Description, lecture.Topic));
                }

                else if (_set[i] is PracticalLesson lesson)
                {
                    result.Add(new PracticalLesson(lesson.Description, lesson.TaskConditionLink, lesson.SolutionLink));
                }
            }

            return result;
        }

        public void Add(Entity entity)
        {
            if (_count < _set.Length)
            {
                _set[_count] = entity;
                _count++;
            }

            else
            {
                Entity[] newSet = new Entity[_set.Length * 3 / 2];

                for (int i = 0; i < _count; i++)
                {
                    newSet[i] = _set[i];
                }

                newSet[_count] = entity;
                _count++;
                _set = newSet;
            }
        }

        public bool IsPractical()
        {
            for (int i = 0; i < _count; i++)
            {
                if (_set[i] is not PracticalLesson)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
