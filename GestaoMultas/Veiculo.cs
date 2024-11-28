public class Veiculo
{
    public int _id_carro;
    public string _niv;
    public string _n_placa;
    public string _n_motor;
    public string _renavam;
    public int _ano_modelo;
    public string _cidade_registro;
    public string _proprietario;
    public string _modelo;
    public Proprietario Proprietario;
    public Cidade cidade;

    public void SetVerificarNiv(string niv)
    {
        


        if (niv.Length == 17)
        {
            

            _niv = niv;
        }
        else
        {
            throw new Exception("Incorreto!");
        };


        
    }

    //public string GetVerificarNiv()
    //{
    //    return _niv;
    //}
}
