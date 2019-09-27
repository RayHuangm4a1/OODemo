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

            CodeBall _CodeBall = new CodeBall("circle", 3);
            string _CodeBallStyle = _CodeBall.GetStyle();
            Console.WriteLine(String.Format("{0}, {1}",_CodeBall.Name, _CodeBall.Size));
            Console.WriteLine(_CodeBallStyle);

             CodeBall _CodeBallBig = new CodeBall("big circle", 10);
            string _CodeBallBigStyle = _CodeBallBig.GetStyle();
            Console.WriteLine(String.Format("{0}, {1}",_CodeBallBig.Name, _CodeBallBig.Size));
            Console.WriteLine(_CodeBallBigStyle);

            Console.WriteLine("=====End OODemo=====");
        }
    }
}
