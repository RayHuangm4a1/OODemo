using System;

namespace CodeBallComponent
{
	public class CodeBallUtils {

		public static CodeBall CreateCodeBallInstance(CodeBallEnum codeBallType)
		{
			switch(codeBallType)
			{
				case CodeBallEnum.Animal:
					return new AnimalCodeBall();
				case CodeBallEnum.Circle:
					return new CircleCodeBall();
				case CodeBallEnum.Rectangle:
					return new RectangleCodeBall();
				case CodeBallEnum.Round:
					return new RoundCodeBall();
				default:
					return new CircleCodeBall();
			}
		}
	}
}
