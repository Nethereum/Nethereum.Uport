using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Nethereum.Uport.Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnGenAddress_Click(object sender, RoutedEventArgs e)
        {
            var barcodeWriter = new ZXing.Mobile.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,
                    Height = 300
                }
            };
            GenerateAddressTopic();
            GenerateAddressUrl(topic);

            var barcode = barcodeWriter.Write(url);
            qrImage.Source = barcode;
        }

        Topic topic;
        string url;

        private void GenerateAddressUrl(Topic topic)
        {
            url = UriBuilder.BuildAddressUri(topic) + "&label=TEST92184091284091284";
        }

        private void GenerateAddressTopic()
        {
            var chasquiUrl = "https://chasqui.uport.me/";
            var server = new UportChasquiServer(chasquiUrl);
            topic = server.NewTopic("address");
        }

        private async void btnGetAddress_Click(object sender, RoutedEventArgs e)
        {
            var chasquiUrl = "https://chasqui.uport.me/";
            var server = new UportChasquiServer(chasquiUrl);
            var response = await server.GetResponseAsync(topic);
            
        }
    }
}
