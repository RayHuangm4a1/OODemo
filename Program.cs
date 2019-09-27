using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using CodeBallComponent;

namespace OODemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=====Start OODemo=====");

            CodeBall _CodeBall = new CodeBall("circle", 5);
            string _CodeBallStyle = _CodeBall.getStyle();
            Console.WriteLine(_CodeBallStyle);

             Console.WriteLine("=====End OODemo=====");
        }
    }
}
