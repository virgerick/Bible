using System;

namespace Bible.Application.Interfaces.Services;

public interface IDateTimeService
{
    DateTime NowUtc { get; }
}