namespace OmniGLM_API.Models;

public class Empty {};

public class ApiResponse<TMeta, TData> where TMeta: new()
{
    public TMeta Meta { get; set; } = new();
    public TData Data { get; set; }
}

public class ApiResponse<TData> : ApiResponse<Empty, TData> {}