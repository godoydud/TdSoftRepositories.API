namespace TdSoftRepositories.API.Domain.DTOs
{
    public class ResponseDTO<TEntity>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public TEntity Entity { get; set; }

        public ResponseDTO() { }

        public ResponseDTO(int statusCode, string message = default)
            : this()
        {
            StatusCode = statusCode;
            Message = message;
        }

        public ResponseDTO(int statusCode, TEntity entity, string message = default)
            : this(statusCode, message)
        {
            StatusCode = statusCode;
            Entity = entity;
        }
    }
}
