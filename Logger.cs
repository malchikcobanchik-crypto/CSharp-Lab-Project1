namespace CSharpLab
{
    public static class Logger
    {

        /// <param name="message">Сообщение для логирования.</param>
        public static void Log(string message)
        {
            System.Console.WriteLine($"[LOG] {message}");
        }


        /// <param name="warning">Текст предупреждения.</param>
        public static void Warn(string warning)
        {
            System.Console.WriteLine($"[WARNING] {warning}");
        }


        /// <param name="error">Текст ошибки.</param>
        public static void Error(string error)
        {
            System.Console.WriteLine($"[ERROR] {error}");
        }
    }
}
