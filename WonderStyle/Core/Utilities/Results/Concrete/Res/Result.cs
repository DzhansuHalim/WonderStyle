﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public bool Succes { get; }

        public string Message { get; }

        public Result(bool success, string message): this(success)
        {
            Message = message;
        }
         
        public Result(bool success)
        {
            Succes = success;
        }


    }
}