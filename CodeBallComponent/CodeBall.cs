using System;

namespace CodeBallComponent
{
	public class CodeBall
	{
		#region private member
		private string m_Name;
		private int m_Size;
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
		public string getStyle()
		{
			return String.Format("I am {0} CodeBall, Style: {1} size", Name, Size.ToString());
		}
		#endregion
	}
}
