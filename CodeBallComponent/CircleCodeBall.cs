using System;

namespace CodeBallComponent
{
	public class CircleCodeBall : CodeBall
	{
		#region constructor
		public CircleCodeBall()
		{
		}
		#endregion

		#region protected method
		protected override string getOtherStyle()
		{
			return String.Format(@"
				border-radius: 50%,
				padding: 0,
				text-align: center,
				width: 20px,
				height: 20px,
			"
			);
		}
		#endregion
	}
}
