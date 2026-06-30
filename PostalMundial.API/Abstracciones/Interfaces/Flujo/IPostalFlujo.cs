using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IPostalFlujo
    {
        Task<IEnumerable<PostalResponse>> Obtener();
        Task<IEnumerable<PostalResponse>> ObtenerFaltantes();
        Task<PostalResponse> Obtener(Guid Id);
        Task<Guid> Agregar(PostalRequest postal);
        Task<Guid> Editar(Guid Id, PostalRequest postal);
        Task<Guid> Eliminar(Guid Id);
    }
}