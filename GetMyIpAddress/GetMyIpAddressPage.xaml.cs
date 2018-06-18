using Xamarin.Forms;

namespace GetMyIpAddress
{
    public partial class GetMyIpAddressPage : ContentPage
    {
        public GetMyIpAddressPage()
        {
            InitializeComponent();

            GetIp();
        }

        void Handle_Pressed(object sender, System.EventArgs e)
        {
            GetIp();
        }

        public void GetIp(){
            string ipAddress = DependencyService.Get<IIPAddressManager>().GetIPAddress();
            txtIPAddress.Text = "My IP Address is: " + ipAddress;
        }
    }
}
