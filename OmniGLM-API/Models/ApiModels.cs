namespace OmniGLM_API.Models;

public class Empty {};

public class ApiResponse<TMeta, TData> where TMeta: new()
{
    public TMeta Meta { get; set; } = new();
    public TData Data { get; set; }
}

public class ApiResponse<TData> : ApiResponse<Empty, TData> {}

public class ApiPayload<TMeta, TData>
{
    public TMeta Meta { get; set; }
    public TData Data { get; set; }
}

public class ApiPayload<TData> : ApiPayload<Empty, TData> {}