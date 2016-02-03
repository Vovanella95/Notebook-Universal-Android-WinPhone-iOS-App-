using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Notebook.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class DetailsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.DetailsView);
        }
    }
}