﻿// See https://aka.ms/new-console-template for more information
class Teacher
{
    SortedList<int, ExamDelegate> _sortedEvents = new();
    Random random = new();
    public event ExamDelegate? ExamEvent
    {
        add
        {
            for (int key = 0; ;)
            {
                key = random.Next();
                if (!_sortedEvents.ContainsKey(key))
                {
                    _sortedEvents.Add(key, value);
                    break;
                }
            }

        }
        remove
        {
            _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
        }
    }
    public void Exam(string task)
    {
        foreach (var key in _sortedEvents.Keys)
        {
            if (_sortedEvents[key] is not null)
                _sortedEvents[key].Invoke(task);
        }
    }
}

