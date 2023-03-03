using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.Core;

public class Result<T>
{
    public T? Value { get; set; }

    public bool IsSuccess { get; set; }

    public string? Message { get; set; }

    public Result(T value, bool isSuccess, string message)
    {
        Value = value;
        IsSuccess = isSuccess;
        Message = message;
    }

    public Result(T value)
    {
        Value = value;
        IsSuccess = true;
        Message = null;
    }

    public Result()
    {
        Value = default(T);
        IsSuccess = false;
        Message = null;
    }

    public void SetOK(T value)
    {
        Value = value;
        IsSuccess = true;
        Message = null;
    }
}
