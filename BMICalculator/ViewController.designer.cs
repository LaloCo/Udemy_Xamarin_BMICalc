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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel bmiLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton calculateButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton detailsButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField heightTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField weightTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (bmiLabel != null) {
				bmiLabel.Dispose ();
				bmiLabel = null;
			}
			if (calculateButton != null) {
				calculateButton.Dispose ();
				calculateButton = null;
			}
			if (detailsButton != null) {
				detailsButton.Dispose ();
				detailsButton = null;
			}
			if (heightTextField != null) {
				heightTextField.Dispose ();
				heightTextField = null;
			}
			if (weightTextField != null) {
				weightTextField.Dispose ();
				weightTextField = null;
			}
		}
	}
}
