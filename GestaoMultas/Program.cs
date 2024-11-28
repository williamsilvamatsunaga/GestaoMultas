public class Program
{
    static void Main(string[] args)
    {
        Veiculo c = new Veiculo();
        ProprietarioPF p = new ProprietarioPF();
        try
        {
            

            string niv;
            Console.WriteLine("Digite o NIV: ");
            niv = Console.ReadLine();

            c.SetVerificarNiv(niv);

            Console.WriteLine("Correto!");

            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Console.WriteLine("Digite CPF");
            string cpf_pessoa_fisica = Console.ReadLine();

            p.SetVerificarCpf(cpf_pessoa_fisica);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
