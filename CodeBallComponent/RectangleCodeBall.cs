using System;

namespace CodeBallComponent
{
	public class RectangleCodeBall : CodeBall
	{
		#region constructor
		public RectangleCodeBall()
		{
			this.m_Name = "Rectangle";
		}
		#endregion

		#region protected method
		protected override string getOtherStyle()
		{
			return String.Format(@"
				border-radius: 5px
				border: 0
				width: 100%
				height: 20px
			"
			);
		}
		#endregion
	}
}

