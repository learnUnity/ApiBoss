namespace ApiBoss
{
    public interface IRequestHandler
    {
        void OnHandleRequest(Request request);
    }
}