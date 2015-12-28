using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BMICalculator
{
	partial class DetailViewController : UIViewController
	{
		public float bmi = 21.5f;

		public DetailViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			EvaluateBMI ();
		}

		void EvaluateBMI()
		{
			string result = String.Empty;

			if (bmi <= 16)
				result = "very low";
			else if (bmi < 18.5)
				result = "low";
			else if (bmi < 25)
				result = "normal";
			else if (bmi < 30)
				result = "high";
			else
				result = "too high";

			resultLabel.Text = result;
		}
	}
}
