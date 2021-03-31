using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDateResult<T>:DataResult<T>
    {
        public SuccessDateResult(T data, string message):base(data, true, message)
        {

        }

        public SuccessDateResult(T data):base(data, true)
        {

        }

        public SuccessDateResult(string message):base(default, true, message)
        {
            
        }

        public SuccessDateResult():base(default, true)
        {

        }
    }
}
