namespace InsanmarTec.Application.Shared.Results
{
    public class Result<T> : Result
    {
        public T? Value { get; private set; }

        protected Result(bool isSuccess, string? errorMessage, T? value)
            : base(isSuccess, errorMessage) => Value = value;

        public static Result<T> Success(T value) => new(true, default, value);

        public static new Result<T> Failure(string errorMessage) =>
            new(default, errorMessage, default);
    }
}
