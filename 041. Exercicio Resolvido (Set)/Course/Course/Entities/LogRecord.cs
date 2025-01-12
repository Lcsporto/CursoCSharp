﻿using System;

namespace Course.Entities
{
    internal class LogRecord
    {
        public String UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }
            LogRecord other = obj as LogRecord;

            return UserName.Equals(other.UserName);
        }
    }
}
