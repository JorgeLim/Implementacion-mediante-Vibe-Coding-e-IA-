namespace Presentation.Responses;

public class ApiResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public object? Data { get; set; }
    public string? Error { get; set; }

    public static ApiResponse Ok(string message = "Operación exitosa", object? data = null)
    {
        return new ApiResponse { Success = true, Message = message, Data = data };
    }

    public static ApiResponse Fail(string message, string? error = null)
    {
        return new ApiResponse { Success = false, Message = message, Error = error };
    }
}