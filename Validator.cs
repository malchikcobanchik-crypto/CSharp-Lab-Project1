namespace CSharpLab
{
	public static class Validator
	{
		/// <param name="input">Строка для проверки.</param>
		public static bool IsValidString(string input)
		{
			return !string.IsNullOrEmpty(input);
		}

		/// <param name="input">Строка для проверки.</param>
		public static bool IsValidNonWhitespaceString(string input)
		{
			return !string.IsNullOrWhiteSpace(input);
		}
	}
}
