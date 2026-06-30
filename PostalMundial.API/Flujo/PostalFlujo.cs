using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;

namespace Flujo
{
    public class PostalFlujo : IPostalFlujo
    {
        private IPostalDA _postalDA;

        public PostalFlujo(IPostalDA postalDA)
        {
            _postalDA = postalDA;
        }

        public Task<Guid> Agregar(PostalRequest postal)
        {
            return _postalDA.Agregar(postal);
        }

        public Task<Guid> Editar(Guid Id, PostalRequest postal)
        {
            return _postalDA.Editar(Id, postal);
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            return _postalDA.Eliminar(Id);
        }

        public Task<IEnumerable<PostalResponse>> Obtener()
        {
            return _postalDA.Obtener();
        }

        public Task<PostalResponse> Obtener(Guid Id)
        {
            return _postalDA.Obtener(Id);
        }

        public Task<IEnumerable<PostalResponse>> ObtenerFaltantes()
        {
            throw new NotImplementedException();
        }
    }
}
