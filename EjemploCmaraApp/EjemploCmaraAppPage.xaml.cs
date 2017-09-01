using Xamarin.Forms;

namespace EjemploCmaraApp
{
    public partial class EjemploCmaraAppPage : ContentPage
    {
        public EjemploCmaraAppPage()
        {
            InitializeComponent();

            CameraButton.Clicked += CameraButton_Clicked;
        }

        async void CameraButton_Clicked(object sender, System.EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(
                new Plugin.Media.Abstractions.StoreCameraMediaOptions() {});

            if (photo != null)
            {
                PhotoImage.Source = ImageSource.FromStream(
                    () => photo.GetStream()
                );
            }
        }
    }
}
