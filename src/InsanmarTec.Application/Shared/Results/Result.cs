namespace InsanmarTec.Application.Shared.Results
{
    public class Result
    {
        public bool IsSuccess { get; private set; }
        public string? ErrorMessage { get; private set; }

        protected Result(bool isSuccess, string? errorMessage)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
        }

        public static Result Success() => new(true, default);

        public static Result Failure(string errorMessage) => new(default, errorMessage);
    }
}
