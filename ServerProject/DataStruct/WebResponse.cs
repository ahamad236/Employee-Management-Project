namespace ServerProject.DataStruct
{
    public class WebResponse
    {
        public bool Success { get; set; }
        public bool Close { get; set; }
        public string? ExceptionMessage { get; set; }
        public object[]? Value { get; set; }
    }
}