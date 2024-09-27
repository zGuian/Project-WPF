﻿namespace Register.Desktop.Application.Commands.Requests
{
    public class Requests<T> where T : class
    {
        public T Datas { get; set; } = null!;
        public string? Message { get; set; }

        public Requests()
        { }

        public Requests(T datas, string? message = null)
        {
            Datas = datas;
            Message = message;
        }
    }
}