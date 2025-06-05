// Standard interfaces

using System.Collections;

class LastNameComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is Student left && y is Student right)
        {
            return string.Compare(left.LastName, right.LastName);
        }
        throw new NotImplementedException();
    }
}

