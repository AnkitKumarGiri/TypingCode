using System;
using System.Collections.Generic;

namespace TypingCodeLibrary
{
    public class TypingCode
    {
        public TypingCode()
        {
            Text = new List<string>();

        }
        public List<string> Text { get; set; }
        public string sayHello()
        {
            return "Hello";
        }
    }
}
