


using System.Linq;
using System.Text;

Random random = new Random();



string[] palavras = { "ABACAXI", "MOUSE", "JANELA", "CUECA", "JORNAL", "PAPELARIA", "RATOEIRA" };   // Palavras a serem sorteadas
int nAleatorio = random.Next(1, palavras.Count()); // Pega uma palavra (posição) aleatória para ser usada no jogo. 

string palavraEscolhida = palavras[nAleatorio]; // Pega a posição e traz para a variável 'palavraEscolhida' a palavra escolhida kkk

char[] palavraEscolhidaOculta = new string('_', palavraEscolhida.Length).ToCharArray();

int erros = 0;
int acertos = 0;

StringBuilder forca = new StringBuilder();


Console.WriteLine("Bem-vindo(a) ao JOGO DA FORCA!");
Console.WriteLine("Regras: Acertar a palavra antes do seu boneco morrer :)");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("digite 'BORA' para começar");

var resposta = Console.ReadLine();
if (resposta.ToUpper() != "BORA")
{
    Console.Clear();
    Console.WriteLine("tchau :(");
}
else
{
    Console.Clear();
    Console.WriteLine($"A palavra contém {palavraEscolhida.Length} letras.");
    Console.WriteLine("Palavra: " + new string(palavraEscolhidaOculta));
    Console.WriteLine();
    Console.WriteLine();

    forca.AppendLine("---------------");
    forca.AppendLine("       |");
    forca.AppendLine("       |");
    Console.WriteLine(forca.ToString());


    do
    {
        Console.Write("Escolha uma letra: ");
        resposta = Console.ReadLine().ToUpper();

        bool acertou = AtualizarPalavra(palavraEscolhida, palavraEscolhidaOculta, resposta);

        if (acertou)
        {
            Console.Clear();
            Console.WriteLine($"A palavra contém {palavraEscolhida.Length} letras.");
            Console.WriteLine("Palavra: " + new string(palavraEscolhidaOculta));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(palavraEscolhidaOculta);
            Console.WriteLine(forca.ToString());
        }
        else if (erros == 1)
        {
            Console.Clear();
            Console.WriteLine($"A palavra contém {palavraEscolhida.Length} letras.");
            Console.WriteLine("Palavra: " + new string(palavraEscolhidaOculta));
            Console.WriteLine();
            Console.WriteLine();
            forca.AppendLine("      ( )");
            Console.WriteLine(forca.ToString());
        }
        else if (erros == 2)
        {
            Console.Clear();
            Console.WriteLine($"A palavra contém {palavraEscolhida.Length} letras.");
            Console.WriteLine("Palavra: " + new string(palavraEscolhidaOculta));
            Console.WriteLine();
            Console.WriteLine();
            forca.AppendLine("       |");
            forca.AppendLine("       |");
            Console.WriteLine(forca.ToString());
        }
        else if (erros == 3)
        {
            Console.Clear();
            Console.WriteLine($"A palavra contém {palavraEscolhida.Length} letras.");
            Console.WriteLine("Palavra: " + new string(palavraEscolhidaOculta));
            Console.WriteLine();
            Console.WriteLine();
            forca.Remove(53, 1);
            forca.Insert(53, "/");
            Console.WriteLine(forca.ToString());
        }
        else if (erros == 4)
        {
            Console.Clear();
            Console.WriteLine($"A palavra contém {palavraEscolhida.Length} letras.");
            Console.WriteLine("Palavra: " + new string(palavraEscolhidaOculta));
            Console.WriteLine();
            Console.WriteLine();
            forca.Remove(48, 9);
            forca.Insert(48, "     / | \\");
            Console.WriteLine(forca.ToString());
        }
        else if (erros == 5)
        {
            Console.Clear();
            Console.WriteLine($"A palavra contém {palavraEscolhida.Length} letras.");
            Console.WriteLine("Palavra: " + new string(palavraEscolhidaOculta));
            Console.WriteLine();
            Console.WriteLine();
            forca.AppendLine("      / ");
            Console.WriteLine(forca.ToString());
        }
        else if (erros == 6)
        {
            Console.Clear();
            Console.WriteLine($"A palavra contém {palavraEscolhida.Length} letras.");
            Console.WriteLine("Palavra: " + new string(palavraEscolhidaOculta));
            Console.WriteLine();
            Console.WriteLine();
            forca.Insert(76, " \\");
            Console.WriteLine(forca.ToString());

            Console.WriteLine();
            Console.WriteLine("HAHAHA PERDEU!!");
            Console.WriteLine("A palavra era: " + palavraEscolhida);
            break;
        }
    } while (acertos != palavraEscolhida.Length);
}

bool AtualizarPalavra(string palavraSecreta, char[] palavraOculta, string tentativa)
{
    bool encontrou = false;

    char tent = tentativa[0];

    for (int i = 0; i < palavraSecreta.Length; i++)
    {
        if (palavraSecreta[i] == tent)
        {
            palavraOculta[i] = tent;
            acertos++;
            return encontrou = true;
        }
    }
    erros++;
    return encontrou;
}








