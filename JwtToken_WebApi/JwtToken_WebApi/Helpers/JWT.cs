namespace JwtToken_WebApi.Helpers
{
	public class JWT
	{

		public string Key { get; set; } = null!;
		public string Issure { get; set; } = null!;
		public string Audience { get; set; } = null!;
		public int DurationInDays { get; set; }
		

	}
}
