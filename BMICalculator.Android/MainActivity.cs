using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace BMICalculator.Android
{
	[Activity (Label = "BMICalculator.Android", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		Button calculateButton, bmiDetailsButton;
		TextView resultTextView;
		EditText heightEditText, weightEditText;

		float bmi = 20.0f;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			Xamarin.Insights.Initialize (XamarinInsights.ApiKey, this);
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			calculateButton = FindViewById<Button> (BMICalculator.Android.Resource.Id.calculateButton);
			resultTextView = FindViewById<TextView> (BMICalculator.Android.Resource.Id.resultTextView);
			heightEditText = FindViewById<EditText> (BMICalculator.Android.Resource.Id.heightEditText);
			weightEditText = FindViewById<EditText> (BMICalculator.Android.Resource.Id.weightEditText);
			bmiDetailsButton = FindViewById<Button> (BMICalculator.Android.Resource.Id.showDetailsButton);

			calculateButton.Click+= CalculateButton_Click;

			bmiDetailsButton.Click += BmiDetailsButton_Click;
		}

		void BmiDetailsButton_Click (object sender, System.EventArgs e)
		{
			var intent = new Intent (this, typeof(BMIDetailsActivity));
			intent.PutExtra ("bmi_value", bmi);
			StartActivity (intent);
		}

		void CalculateButton_Click (object sender, System.EventArgs e)
		{
			float height = float.Parse (heightEditText.Text);
			float weight = float.Parse (weightEditText.Text);

			bmi = (weight / (height * height));

			resultTextView.Text = bmi.ToString ();
		}
	}
}
