namespace CpfCpnj_poo
{
    public class Pessoa
    {
        public string nome;
        /// <summary>
        /// Saudar o usuário
        /// </summary>
        /// <returns>Texto de saudação com o nome do usuário</returns>
        public string Saudar(){
            return "Seja bem vindo(a)" + nome;
        }
    }
}