using System.Collections.Generic;
using System.Threading.Tasks;
using WebAsync.Models;

namespace WebAsync.Business
{
    public class HomeBusiness
    {
        public List<Pessoa> GetPerson()
        {
            List<Pessoa> pessoaList = new List<Pessoa>();
            for (int i = 0; i < 5000; i++)
            {
                Pessoa pessoa = new Pessoa()
                {
                    Id = 1,
                    Nome = "Deybson",
                    Sobrenome = "Ferreira",
                    Documento = "123456789"
                };
                pessoaList.Add(pessoa);
            }
            return pessoaList;
        }
        public async Task<List<Pessoa>> GetPersonAsync()
        {
            List<Pessoa> pessoaList = new List<Pessoa>();

            for (int i = 0; i < 5000; i++)
            {
                Pessoa pessoa = new Pessoa()
                {
                    Id = 1,
                    Nome = "Deybson",
                    Sobrenome = "Ferreira",
                    Documento = "123456789"
                };
                pessoaList.Add(pessoa);
            }

            Task<List<Pessoa>> personTask = Task.FromResult<List<Pessoa>>(pessoaList);

            return await personTask;

        }
    }
}