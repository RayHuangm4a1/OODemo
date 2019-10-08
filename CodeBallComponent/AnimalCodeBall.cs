using System;

namespace CodeBallComponent
{
	public class AnimalCodeBall : CodeBall
	{
		#region constructor
		public AnimalCodeBall()
		{
		}
		#endregion

		#region protected method
		protected override string getOtherStyle()
		{
			return String.Format(@"
					'0': '🐭',
					'1': '🐂',
					'2': '🐯',
					'3': '🐰',
					'4': '🐲',
					'5': '🐍',
					'6': '🐎',
					'7': '🐑',
					'8': '🐒',
					'9': '🐔',
				");
		}
		#endregion
	}
}

