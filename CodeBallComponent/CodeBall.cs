using System;

namespace CodeBallComponent
{
	public abstract class CodeBall
	{
		#region protected member
		protected string m_Shape;
		protected IButtonClick m_ButtonClick;
		protected IHover m_Hover;

		#endregion

		#region constructor
		public CodeBall()
		{
		}
		#endregion

		#region property
		public string Name
		{
			get; set;
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
		public void setIButtonClick(IButtonClick buttonClick)
		{
			this.m_ButtonClick = buttonClick;
		}
		public void setIHover(IHover hover)
		{
			this.m_Hover = hover;
		}

		public string Click()
		{
			return this.m_ButtonClick.Click();
		}

		public string Hover()
		{
			return this.m_Hover.Hover();
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
