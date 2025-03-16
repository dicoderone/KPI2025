using KPIdomain.Common;

namespace KPIapplication.Models
{
    public class ApiResult
    {
        public bool IsSuccess { get; private set; }
        public string? SuccessMessage { get; private set; }
        public bool IsFailure => !IsSuccess;
        public Error? Error { get; private set; }

        protected internal ApiResult(bool IsSuccess, string? SuccessMessage, Error? error)
        {
            if (IsSuccess && error != Error.None)
            {
                throw new InvalidOperationException("Success result can't have an error.");
            }

            if (!IsSuccess && error == Error.None)
            {
                throw new InvalidOperationException("Failure result  must have an error.");
            }

            this.IsSuccess = IsSuccess;
            this.SuccessMessage = SuccessMessage;
            Error = error ?? Error.None;
        }

        public static ApiResult Success() => new ApiResult(true, string.Empty, null);

        public static ApiResult Success(string? SuccessMessage = null) => new ApiResult(true, SuccessMessage, null);

        public static ApiResult Failure() => new ApiResult(false, string.Empty, Error.None);

        public static ApiResult Failure(Error error) => new ApiResult(false, string.Empty, error);

        public static ApiResult Failure(Error error, string? SuccessMessage = null) => new ApiResult(false, SuccessMessage, error);
    }

    public class ApiResult<TValue> : ApiResult
    {
        private TValue? _value;

        protected internal ApiResult(TValue? value, string? successMessage, bool isSuccess, Error? error)
            : base(isSuccess, successMessage, error)
        {
            _value = value;
        }

        public TValue Value => IsSuccess ? _value! : throw new InvalidOperationException("The value of a failure result cannot be accessed.");

        // Sort method for collections
        public void Sort(Func<TValue, TValue, int> comparator)
        {
            if (_value is IEnumerable<TValue> collection)
            {
                var sortedCollection = collection.OrderBy(item => item, new ComparisonComparer(comparator));
                _value = (TValue)(object)sortedCollection.ToList(); // Using List for sorting
            }
            else
            {
                throw new InvalidOperationException("Value must be a collection to sort.");
            }
        }

        public static ApiResult<TValue> Success(TValue value, string? successMessage = null)
            => new ApiResult<TValue>(value, successMessage, true, Error.None);

        public static ApiResult<TValue> Failure(Error error, string? failureMessage = null)
            => new ApiResult<TValue>(default, failureMessage, false, error);

        public static ApiResult<TValue> Create(TValue? value)
            => value != null ? Success(value) : Failure(Error.NullValue);

        public static implicit operator ApiResult<TValue>(TValue? value) => Create(value);

        private class ComparisonComparer : IComparer<TValue>
        {
            private readonly Func<TValue, TValue, int> _comparator;

            public ComparisonComparer(Func<TValue, TValue, int> comparator)
            {
                _comparator = comparator;
            }

            public int Compare(TValue x, TValue y) => _comparator(x, y);
        }
    }
}
