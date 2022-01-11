using Xamarin.Forms;

namespace lelab.Views
{
    public partial class ContPage : ContentPage
    {
        int count = 0;

        public ContPage()
        {
            InitializeComponent();
        }

        void CountButtonClick(System.Object sender, System.EventArgs e)
        {
            count++;
            countLabel.Text = count.ToString();
         
        }
    }
}
