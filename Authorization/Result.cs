using System;
using System.Collections.Generic;

namespace Authorization
{
    public interface IResult
    {
        ResultType Type { get; set; }
        string Message { get; }

        void AddMessage(string msg);

        void ClearMessages();
    }

    public class Result : IResult
    {
        private List<string> _messages;

        public ResultType Type { get; set; }

        public string Message => throw new NotImplementedException();

        public Result(ResultType defaultType = ResultType.InConclusive)
        {
            Type = defaultType;
            _messages = new List<string>();
        }

        public void AddMessage(string msg)
        {
            _messages.Add(msg);
        }

        public void ClearMessages()
        {
            _messages.Clear();
        }
    }

    public enum ResultType
    {
        InConclusive = 0,
        Failure = -1,
        Successful = 1
    }
}