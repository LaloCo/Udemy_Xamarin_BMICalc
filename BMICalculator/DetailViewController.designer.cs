// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BMICalculator
{
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView bmiDetailLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel resultLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (bmiDetailLabel != null) {
				bmiDetailLabel.Dispose ();
				bmiDetailLabel = null;
			}
			if (resultLabel != null) {
				resultLabel.Dispose ();
				resultLabel = null;
			}
		}
	}
}
