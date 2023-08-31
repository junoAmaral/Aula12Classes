
using Aula12Classes;

Console.WriteLine("Olá, nerd! Bem-vinde ao RPG da Programação. Escolha seu personagem:");

Personagem bardo = new Personagem();
bardo.nome = "Dudu";
bardo.raca = "Humano";
bardo.poder = 1000;

bardo.mostra();

Personagem mago = new Personagem();
mago.nome = "Du";
mago.raca = "Elfo negro";
mago.poder = 1500;

mago.mostra();

Personagem bruxo = mago;
bruxo.nome = "Matheus";
bruxo.mostra();

Personagem guerreiro = new Personagem();
guerreiro.nome = "Conradito";
guerreiro.raca = "Anão";
guerreiro.poder = 500;

guerreiro.mostra();