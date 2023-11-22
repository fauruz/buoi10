using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Question
    {
        public int Id {  get; set; }
        public string Content { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string Answer {  get; set; }
        public Question(int id, string content, string a, string b, string c, string d, string answer)
        {
            Id = id;
            Content = content;
            A = a;
            B = b;
            C = c;
            D = d;
            if (answer == "A")
            {
                Answer = a;
            }
            else if (answer == "B")
            {
                Answer = b;
            }
            else if (answer == "C")
            {
                Answer = c;
            }
            else
                Answer = d;
        }
        public Question() 
        {
            Id = 0;
            Content = string.Empty;
            A = string.Empty;
            B = string.Empty;
            C = string.Empty;
            D = string.Empty;
            if (Answer == "A")
            {
                Answer = A;
            }
            else if (Answer == "B")
            {
                Answer = B;
            }
            else if (Answer == "C")
            {
                Answer = C;
            }
            else
                Answer = D;
        }
    }
}
