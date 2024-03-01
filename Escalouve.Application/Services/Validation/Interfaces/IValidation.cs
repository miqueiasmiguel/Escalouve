namespace Escalouve.Application.Services.Validation.Interfaces
{
    public interface IValidation<T>
    {
        void Validar(T dto);
    }
}
