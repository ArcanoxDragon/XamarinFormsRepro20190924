namespace XamarinFormsRepro
{
    public abstract class Data
    {
        public abstract string Value { get; }
    }

	public class FruitData : Data
	{
		public override string Value => "Apple";
	}

	public class ColorData : Data
	{
		public override string Value => "Red";
	}
}
