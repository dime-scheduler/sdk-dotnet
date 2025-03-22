﻿using System.Collections.Generic;

namespace Dime.Scheduler
{
    public class Result
    {
        protected Result(bool isSuccess, string? error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }

        protected Result(bool isSuccess) : this(isSuccess, string.Empty)
        {
        }

        public Result(bool isSuccess, string error, IEnumerable<AppointmentMap> appointments)
            : this(isSuccess, error)
        {
            Appointments = appointments;
        }

        public bool IsFailure => !IsSuccess;

        public bool IsSuccess { get; }

        public string? Error { get; }
        public IEnumerable<AppointmentMap> Appointments { get; }

        internal static Result Fail(string error)
            => new(false, error);

        internal static Result<T> Fail<T>(string error)
            => new(default, false, error);

        internal static Result Ok()
            => new(true);

        internal static Result Ok<T>(T value, IEnumerable<AppointmentMap> appointments)
            => new(true, string.Empty, appointments);

        internal static Result<T> Ok<T>(T value)
            => new(value, true);
    }
}