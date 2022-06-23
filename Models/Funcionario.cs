namespace TrilhaNetAzureDesafio.Models
{
    public class Funcionario
    {
        public Funcionario() { }

        public Funcionario(int id, string nome, string endereco, string ramal, string emailProfissional, string departamento, decimal salario, DateTime dataAdmissao)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Ramal = ramal;
            EmailProfissional = emailProfissional;
            Departamento = departamento;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Ramal { get; set; }
        public string EmailProfissional { get; set; }
        public string Departamento { get; set; }
        public decimal Salario { get; set; }
        public DateTimeOffset? DataAdmissao { get; set; }
    }
}