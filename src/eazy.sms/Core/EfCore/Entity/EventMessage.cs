﻿namespace eazy.sms.Core.EfCore.Entity
{
    public class EventMessage : IEntity
    {
        public string Message { get; set; }
        public string Exceptions { get; set; }
        public int Status { get; set; }
    }
}