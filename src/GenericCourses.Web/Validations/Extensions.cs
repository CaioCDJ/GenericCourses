
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GenericCourses.Web.Validations;

public static class Extensions {
	public static void AddToModelState(this ValidationResult result, ModelStateDictionary modelState) {
		foreach (var error in result.Errors) {
			modelState.AddModelError(error.PropertyName.ToLower(), error.ErrorMessage);
		}
	}
}
