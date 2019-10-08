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

            CodeBallComponent.CodeBall _AnimalCodeBall = CodeBallUtils.CreateCodeBallInstance(CodeBallEnum.Animal);
            CodeBallComponent.CodeBall _CircleCodeBall = CodeBallUtils.CreateCodeBallInstance(CodeBallEnum.Circle);
            CodeBallComponent.CodeBall _RectangleCodeBall = CodeBallUtils.CreateCodeBallInstance(CodeBallEnum.Rectangle);
            CodeBallComponent.CodeBall _RoundCodeBall = CodeBallUtils.CreateCodeBallInstance(CodeBallEnum.Round);

            Console.WriteLine(_AnimalCodeBall.GetStyle());
            Console.WriteLine(_CircleCodeBall.GetStyle());
            Console.WriteLine(_RectangleCodeBall.GetStyle());
            Console.WriteLine(_RoundCodeBall.GetStyle());

            _AnimalCodeBall.setIButtonClick(new ButtonClickToBoom());
            _AnimalCodeBall.setIHover(new HoverToShowTooltips());
            Console.WriteLine(string.Format("{0}, {1}",
                _AnimalCodeBall.Click(),
                _AnimalCodeBall.Hover()));

            Console.WriteLine("=====End OODemo=====");
        }
    }
}
