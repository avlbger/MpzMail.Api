﻿using System;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [Serializable]
    public enum TrackingType
    {
        [XmlEnum("0")]
        All = 0,
        [XmlEnum("1")]
        Createcall
    }
}
