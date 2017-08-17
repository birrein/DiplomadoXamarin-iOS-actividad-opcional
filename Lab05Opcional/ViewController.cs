using System;

using UIKit;

namespace Lab05Opcional
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            NumberOne.TouchUpInside += (object sender, EventArgs e) => 
            {
                ResultText.Text = ResultText.Text+"1";
            };
			NumberTwo.TouchUpInside += (object sender, EventArgs e) =>
			{
				ResultText.Text = ResultText.Text + "2";
			};
			NumberThree.TouchUpInside += (object sender, EventArgs e) =>
			{
				ResultText.Text = ResultText.Text + "3";
			};
			NumberFour.TouchUpInside += (object sender, EventArgs e) =>
			{
				ResultText.Text = ResultText.Text + "4";
			};
			NumberFive.TouchUpInside += (object sender, EventArgs e) =>
			{
				ResultText.Text = ResultText.Text + "5";
			};
			NumberSix.TouchUpInside += (object sender, EventArgs e) =>
			{
				ResultText.Text = ResultText.Text + "6";
			};
			NumberSeven.TouchUpInside += (object sender, EventArgs e) =>
			{
				ResultText.Text = ResultText.Text + "7";
			};
			NumberEight.TouchUpInside += (object sender, EventArgs e) =>
			{
				ResultText.Text = ResultText.Text + "8";
			};
			NumberNine.TouchUpInside += (object sender, EventArgs e) =>
			{
				ResultText.Text = ResultText.Text + "9";
			};
			NumberZero.TouchUpInside += (object sender, EventArgs e) =>
			{
				ResultText.Text = ResultText.Text + "0";
			};
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
