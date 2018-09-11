namespace ApiBoss
{
    public interface IErrorHandler
    {
        void OnHandleError(Request request);
    }
}