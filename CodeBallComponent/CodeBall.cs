using System;

namespace CodeBallComponent
{
	public class CodeBall
	{
		#region protected member
		protected string m_Name;
		protected string m_Shape;
		#endregion

		#region constructor
		public CodeBall()
		{
		}
		#endregion

		#region property
		public string Name
		{
			get {
				return this.m_Name;
			}

			set {

			}
		}
		#endregion

		#region public method
		public string GetStyle()
		{
			return String.Format("I am {0} CodeBall, Style: {1}",
				Name,
				getOtherStyle()
			);
		}
		#endregion

		#region protected method
		protected virtual string getOtherStyle()
		{
			return string.Empty;
		}
		#endregion
	}
}
