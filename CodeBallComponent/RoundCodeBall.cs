using System;

namespace CodeBallComponent
{
	public class RoundCodeBall : CodeBall
	{
		#region constructor
		public RoundCodeBall()
		{
		}
		#endregion

		#region protected method
		protected override string getOtherStyle()
		{
			return String.Format(@"
				border-radius: 4px
				border: 1px solid $round-border-color
			"
			);
		}
		#endregion
	}
}

