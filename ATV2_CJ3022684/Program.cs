namespace ATV2_CJ3022684
{

    static void Main(string[] args)
    {
        float salario;

        //leitura de salário
        Console.WriteLine("Digite um salário");
        salario = float.Parse(Console.ReadLine());

        salario = salario + (25.0f / 100.0f) * salario;
        Console.WriteLine("O novo salrio é R$ {0} ", salario);
        Console.ReadKey();
    }
}