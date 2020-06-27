using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PrototypePattern
{
    public class Email : ICloneable
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool UseSSL { get; set; }
        public List<FileInfo> Attachments { get; set; }
        public int EmailType { get; set; }
        public int Priority { get; set; }
        public string CCAddress { get; set; }
        public string BCCAddress { get; set; }
        public string ReplyToAddress { get; set; }

        public Email Clone()
        {
            return new Email()
            {
                Username = this.Username,
                Password = this.Password,
                UseSSL = this.UseSSL
            };
        }

        object ICloneable.Clone()
        {
            return new Email()
            {
                Username = this.Username,
                Password = this.Password,
                UseSSL = this.UseSSL
            };
        }
    }
}
