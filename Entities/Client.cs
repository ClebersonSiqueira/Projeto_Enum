using System;
namespace Projeto_Fixacao_Enum.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Cria um objeto de cliente vazio
        /// </summary>
        public Client()
        {

        }

        /// <summary>
        /// Cria um objeto de cliente com os dados
        /// </summary>
        /// <param name="name">Nome do cliente</param>
        /// <param name="email">Email do cliente</param>
        /// <param name="birthDate">Data de nascimento do cliente</param>
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return Name + " (" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email;
        }
    }
}
