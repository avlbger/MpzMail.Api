﻿using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class NewsletterAddResult : BaseResult
    {
        [XmlElement("newsletterId")]
        public int NewsletterId { get; set; }
    }
}
