namespace OmniGLM_API.Models
{
    public class Empty {}

    public interface IValidatable
    {
        bool IsValid();
    }

    public class ApiPayload<TMeta, TData> : IValidatable
        where TData : IValidatable
    {
        public TMeta Meta { get; set; }
        public TData Data { get; set; }

        public virtual bool IsValid()
        {
            if (Data == null) return false;

            return Data.IsValid();
        }
    }

    public class ApiPayload<TData> : ApiPayload<Empty, TData>
        where TData : IValidatable {}
}