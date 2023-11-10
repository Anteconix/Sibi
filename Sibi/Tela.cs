namespace Sibi
{
    class Tela
{
    // propriedades
    ConsoleColor corTexto, corFundo;


    // construtor
    public Tela(ConsoleColor ct = ConsoleColor.White,
                ConsoleColor cf = ConsoleColor.Black)
    {
        this.corFundo = cf;
        this.corTexto = ct;

        this.configurarTela();
    }


    public void configurarTela()
    {
        Console.BackgroundColor = this.corFundo;
        Console.ForegroundColor = this.corTexto;
        Console.Clear();
    }