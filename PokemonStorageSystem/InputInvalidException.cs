namespace customException;

[System.Serializable]
public class InputInvalidExceptionException : System.Exception
{
    public InputInvalidExceptionException() { }
    public InputInvalidExceptionException(string message) : base(message) { }
    public InputInvalidExceptionException(string message, System.Exception inner) : base(message, inner) { }
    protected InputInvalidExceptionException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}