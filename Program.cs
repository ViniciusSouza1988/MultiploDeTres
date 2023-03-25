int quantidadeMultiplosDeTres = 0;
int numeroMaximoParaTestar = 89781;
for (int i = 0; i <= numeroMaximoParaTestar; i += 3)
{
    if (i % 3 == 0)
        quantidadeMultiplosDeTres++;
}

Console.WriteLine("Existem " + quantidadeMultiplosDeTres + " Multiplos de 3 de 0 a " + numeroMaximoParaTestar);
