using System;

namespace CodeBallComponent
{
	public class CodeBall
	{
		#region private member
		private string m_Name;
		private int m_Size;
		private string m_Color;
		private string m_Background;
		private bool m_hasBorder;
		#endregion

		#region constructor
		public CodeBall(string name, int size)
		{
			this.m_Name = name;
			this.m_Size = size;
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

		public int Size
		{
			get {
				return this.m_Size;
			}

			set {

			}
		}
		#endregion

		#region public method
		public string GetStyle()
		{
			return String.Format("I am {0} CodeBall, Style: {1} size, {2}",
				Name,
				Size.ToString(),
				getOtherStyle()
			);
		}
		#endregion

		#region private method
		private string getOtherStyle()
		{
			if(Size < 6) {
				this.m_Color = "green";
				this.m_Background = "white";
				this.m_hasBorder = true;
			} else {
				this.m_Color = "orange";
				this.m_Background = "transparent";
				this.m_hasBorder = false;
			}

			return String.Format(" {0} color, {1} background-color, border: {2}",
				this.m_Color,
				this.m_Background,
				this.m_hasBorder.ToString()
			);
		}
		#endregion
	}
}
