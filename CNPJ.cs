namespace CpfCpnj_poo
{
    // Para colocar herança:
    public class CNPJ : Pessoa
    {
        public string cnpj;
        /// <summary>
        /// Validar o CNPJ
        /// </summary>
        /// <returns>Se o CNPJ é verdadeiro ou falso</returns>
        public bool ValidarCNPJ(){
           
            if(cnpj != null){
                return true;
                

            }

            return false;
        }
    }
}