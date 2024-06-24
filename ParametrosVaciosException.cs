namespace AtrapameEntidades
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException() : base() { }
        public ParametrosVaciosException(string message) : base(message) { }
        public ParametrosVaciosException(string message, Exception innerException) : base(message, innerException) { }

    }
}
