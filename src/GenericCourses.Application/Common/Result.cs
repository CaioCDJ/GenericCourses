namespace GenericCourses.Application.Common;

// stolen from:
// https://medium.com/@wgyxxbf/result-pattern-a01729f42f8c
public class Result<TValue, TError> {
	public readonly TValue? Value;
	public readonly TError? Error;

	public readonly bool isSuccess;

	private Result(TValue value) {
		isSuccess = true;
		Value = value;
		Error = default;
	}

	private Result(TError error) {
		isSuccess = false;
		Value = default;
		Error = error;
	}

	//happy path
	public static implicit operator Result<TValue, TError>(TValue value) => new Result<TValue, TError>(value);

	//error path
	public static implicit operator Result<TValue, TError>(TError error) => new Result<TValue, TError>(error);
}

public sealed record Error(string Code, string? Message = null);
