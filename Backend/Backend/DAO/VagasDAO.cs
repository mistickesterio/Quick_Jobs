using Backend.DTO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Backend.DAO
{
	public class VagasDAO
	{
		public List<VagaDTO> ListarVagas()
		{
			var conexao = ConnectionFactory.Build();
			conexao.Open();

			var query = "SELECT*FROM Vagas";

			var comando = new MySqlCommand(query, conexao);
			var dataReader = comando.ExecuteReader();

			var vagas = new List<VagaDTO>();

			while (dataReader.Read())
			{
				var vaga = new VagaDTO();
				vaga.ID = int.Parse(dataReader["ID"].ToString());
				vaga.Titulo = dataReader["Titulo"].ToString();
				vaga.Empresa = dataReader["Empresa"].ToString();
				vaga.Descricao = dataReader["Descricao"].ToString();
				vaga.Link = dataReader["Link"].ToString();
				vaga.Salario = dataReader["Salario"].ToString();
				vaga.Imagem = dataReader["Imagem"].ToString();
				vagas.Add(vaga);
			}
			conexao.Close();

			return vagas;
		}
	}
}
