using Xamarin.Forms.Xaml;

namespace XamarinFormsRepro
{
	[XamlCompilation( XamlCompilationOptions.Compile )]
	public partial class FruitView : GenericViewBase<FruitData>
	{
		public FruitView()
		{
			this.InitializeComponent();
		}
	}
}