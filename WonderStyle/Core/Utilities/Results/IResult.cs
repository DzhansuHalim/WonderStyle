using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Base interface for the void methods
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
