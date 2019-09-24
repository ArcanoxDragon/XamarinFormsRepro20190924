using Xamarin.Forms;

namespace XamarinFormsRepro
{
    public class GenericViewBase<TData> : ContentView where TData : Data, new()
	{
		private readonly TData data;

		public GenericViewBase()
		{
			this.data = new TData();
		}

		public string DataValue => this.data.Value;
	}
}
