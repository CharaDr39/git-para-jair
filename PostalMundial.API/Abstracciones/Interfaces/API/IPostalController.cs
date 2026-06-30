using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Abstracciones.Interfaces.API
{
    public interface IPostalController
    {
        Task<IActionResult> Obtener();

        Task<IActionResult> ObtenerFaltantes();

        Task<IActionResult> Obtener(Guid Id);

        Task<IActionResult> Agregar(PostalRequest postal);

        Task<IActionResult> Editar(Guid Id, PostalRequest postal);

        Task<IActionResult> Eliminar(Guid Id);
    }

}