namespace CSharpLab
{
	public class Config
	{
		public string AppName { get; set; } = "MyApp";
		public int MaxConnections { get; set; } = 10;
		public bool EnableLogging { get; set; } = true;
		public string DatabaseServer { get; set; } = "localhost";
		public int Port { get; set; } = 5432;
	}
}
