namespace CpfCpnj_poo
{
    // Para colocar herança:
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;
        /// <summary>
        /// Validar cpf
        /// </summary>
        /// <returns>Se o cpf é verdadeiro ou não</returns>
        public bool  ValidarCPF(){
            if(cpf !=null){
                return true;
            }

            return false;
        }
    }
}