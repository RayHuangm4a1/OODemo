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
            _AnimalCodeBall.setIButtonClick(new ButtonClickToBoom());
            _AnimalCodeBall.setIHover(new HoverToShowTooltips());
            Console.WriteLine(string.Format("when click: {0}, when hover: {1}",
            _AnimalCodeBall.Click(),
            _AnimalCodeBall.Hover()));

            Console.WriteLine(_CircleCodeBall.GetStyle());
            _CircleCodeBall.setIButtonClick(new ButtonClickToClose());
            _CircleCodeBall.setIHover(new HoverToZoomIn());
            Console.WriteLine(string.Format("when click: {0}, when hover: {1}",
            _CircleCodeBall.Click(),
            _CircleCodeBall.Hover()));

            Console.WriteLine(_RectangleCodeBall.GetStyle());
            Console.WriteLine(_RoundCodeBall.GetStyle());

            Console.WriteLine("=====End OODemo=====");
        }
    }
}
