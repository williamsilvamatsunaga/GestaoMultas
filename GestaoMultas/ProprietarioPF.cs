public class ProprietarioPF:Proprietario
{
    public int _id_pessoa_fisica;
    public string _cpf;
    public string _rg;
    public string _data_nasc;
    public string _sexo;

    public void SetVerificarCpf(string cpf_pessoa_fisica)
    {
        try
        {
            if (cpf_pessoa_fisica.Length == 11)
            {
                _cpf = cpf_pessoa_fisica;
            }
            else
            {
                throw new Exception("Errado");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }      
    }
}
