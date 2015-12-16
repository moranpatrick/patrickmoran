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

namespace SpursFanApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            addTextContent();
        }

        public void addTextContent()
        {
            tblHome.Text = "Welcome to my Tottenham Hotspur Fan App.\nTottenham Hotspur, also known as Spurs, is an English Football Club based in London.\nThey currently play in the English top flight division and as of December 2015 their current world ranking is 53.";
            tblHome1.Text = "Tottenham Play their football at White Hart Lane. The stadium was built in 1899 and now has a capacity of 36,284. There are plans currently to convert this stadium into a 61000 capacity Venue. Click on the image for a closer look!";
            tblKit.Text = "Below Are the 2015/16 Jerseys for Tottenham Hotsur";
            tblGallery.Text = "Welcome to my Tottenham Hotspur Gallery.\nHere are some images of the current squad.\nClick on an image to enlarge.";
            tblAbout.Text = "My name is Patrick Moran and I'm currently in second year studying software development in GMIT in Galway, Ireland. I've made this application using for my Mobile Application module, using Microsoft Visual Studio 2015. The app is written in C# and xaml.";
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //when the user clicks on the image, copy that image to the big image, then set the image to visible

            Image mySmallImage = (Image)sender;
            myBigImage.Source = mySmallImage.Source;
            myBigImage.Width = Window.Current.Bounds.Width;
            myBigImage.Height = Window.Current.Bounds.Height;
            myBigImage.Visibility = Visibility.Visible;


        }

        private void myBigImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            myBigImage.Source = null;
            myBigImage.Visibility = Visibility.Collapsed;
        }
    }
}
