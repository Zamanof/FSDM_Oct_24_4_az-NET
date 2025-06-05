// Standard interfaces

using System.Collections;

class DateComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if(x is Student left && y is Student right)
        {
            return DateTime.Compare(left.BirthDate, right.BirthDate);
        }
        throw new NotImplementedException();
    }
}

