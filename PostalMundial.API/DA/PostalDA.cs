using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class PostalDA : IPostalDA
    {
        private readonly IRepositorioDapper _repositorioDapper;
        private readonly SqlConnection _sqlConnection;

        public PostalDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        public async Task<Guid> Agregar(PostalRequest postal)
        {
            string query = @"AgregarPostal";
            var resultadoConsulta = await _sqlConnection.ExecuteScalarAsync<Guid>(query, new
            {
                IdPais = postal.IdPais,
                IdGrupo = postal.IdGrupo,
                Numero = postal.Numero,
                Tengo = postal.Tengo,
                Notas = postal.Notas
            });
            return resultadoConsulta;
        }

        public async Task<Guid> Editar(Guid Id, PostalRequest postal)
        {
            await VerificaPostalExiste(Id);
            string query = @"EditarPostal";


            var resultadoConsulta = await _sqlConnection.ExecuteScalarAsync<Guid>(query, new
            {
                Id = Id,

                IdPais = postal.IdPais
,
                IdGrupo = postal.IdGrupo
,
                Numero = postal.Numero
,
                Tengo = postal.Tengo
            });
            return resultadoConsulta;
        }

        private async Task VerificaPostalExiste(Guid Id)
        {
            PostalResponse? resultadoConsultaPostal = await Obtener(Id);
            if (resultadoConsultaPostal == null)
                throw new Exception("No se encontro la postal");
        }

        public async Task<Guid> Eliminar(Guid Id)
        {
            await VerificaPostalExiste(Id);
            string query = @"EliminarPostal";
            var resultadoConsulta = await _sqlConnection.ExecuteScalarAsync<Guid>(query, new
            {
                Id = Id
            });
            return resultadoConsulta;
        }

        public async Task<IEnumerable<PostalResponse>> Obtener()
        {
            string query = @"ObtenerPostales";
            var resultadoConsulta = await _sqlConnection.QueryAsync<PostalResponse>(query);
            return resultadoConsulta;
        }

        public async Task<PostalResponse> Obtener(Guid Id)
        {
            string query = @"ObtenerPostal";
            var resultadoConsulta = await _sqlConnection.QueryAsync<PostalResponse>(query, 
                new {Id=Id});
            return resultadoConsulta.FirstOrDefault();
        }

        public Task<IEnumerable<PostalResponse>> ObtenerFaltantes()
        {
            throw new NotImplementedException();
        }
    }
}
