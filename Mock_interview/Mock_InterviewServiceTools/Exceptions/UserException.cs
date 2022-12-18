using System;

namespace Mock_interview.Mock_InterviewServiceTools.Exceptions
{
    public class UserException : Exception
    {
        public int Code { get; set; }

        public UserException(int code, string message) :
            base(message) =>
            this.Code = code;
    }
}
