using Core.CrossCuttingConcerns.Exceptions.Types;

namespace Core.CrossCuttingConcerns.Exceptions.Handlers;

public abstract class ExceptionHandler
{
    public Task HandleExceptionAsync(Exception exception)
    {
        if (exception is BusinessException businessException)
            return HandleException(businessException);

        if (exception is ValidationException validationException)
            return HandleException(validationException);

        return HandleException(exception);
    }


    protected abstract Task HandleException(BusinessException businessException);
    protected abstract Task HandleException(ValidationException businessException);
    protected abstract Task HandleException(Exception exception);

}
