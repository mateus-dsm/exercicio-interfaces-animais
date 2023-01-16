namespace Exercicio17
{
    internal class Program
    {
        public abstract class Animal
        {
            public string Nome { get; set; }
            public DateTime DataDeNascimento { get; set; }
            public char Sexo { get; set; }
            public int Idade { get; set; }
            public bool Carnivoro { get; set; }
            public bool Peconhento { get; set; }

            public void Movimentar()
            {
                Console.WriteLine("Me movimentando...");
            }

            public void Comunicar()
            {
                Console.WriteLine("Me comunicando...");
            }

            public void Alimentar()
            {
                Console.WriteLine("Me alimentando...");
            }
        }

        public class Mamifero : Animal 
        {
            public int QuantidadeMamas { get; set; }
            public bool TemPelos { get; set; }
            public string CorPelo { get; set; }

            public void Amamentar()
            {
                Console.WriteLine("Amamentando...");
            }
        }

        public class Ave : Animal
        {
            public bool Rapina { get; set; }
            public string CorPena { get; set; }

            public void Ciscar()
            {
                Console.WriteLine("Ciscando...");
            }
        }

        public class Reptil : Animal
        {
            public bool TemEscamas { get; set; }
            public bool TemCasco { get; set; }
        }

        interface IOviparo
        {
            public void BotarOvo();
            public void ChocarOvo();
        }

        interface IVoar
        {
            public void Voar();
            public int AltitudeMaximaEmMetros { get; }
            public double VelocidadeDoVoo { get; }
        }

        interface IAquatico
        {
            public bool ViveEmTerra { get; }
            public bool Mergulha { get; }
            public bool ViveEmAguaDoce { get; }
        }

        public class Leao : Mamifero
        {
            public Leao(string nome, DateTime dataDeNascimento, char sexo, int idade, int quantidadeMamas, string corPelo)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = true;
                Peconhento = false;
                QuantidadeMamas = quantidadeMamas;
                TemPelos = true;
                CorPelo = corPelo;
            }
        }

        public class Chacal : Mamifero
        {
            public Chacal(string nome, DateTime dataDeNascimento, char sexo, int idade, int quantidadeMamas, string corPelo)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = true;
                Peconhento = false;
                QuantidadeMamas = quantidadeMamas;
                TemPelos = true;
                CorPelo = corPelo;
            }
        }

        public class Morcego : Mamifero, IVoar
        {
            public int AltitudeMaximaEmMetros { get; set; }
            public double VelocidadeDoVoo { get; set; }

            public void Voar()
            {
                Console.WriteLine("Voando...");
            }

            public Morcego(string nome, DateTime dataDeNascimento, char sexo, int idade, int quantidadeMamas, string corPelo, int altitudeMaximaEmMetros, double velocidadeDoVoo)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = false;
                Peconhento = false;
                QuantidadeMamas = quantidadeMamas;
                TemPelos = true;
                CorPelo = corPelo;
                AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
                VelocidadeDoVoo = velocidadeDoVoo;
            }
        }

        public class Cisne : Ave, IOviparo
        {
            public void BotarOvo()
            {
                Console.WriteLine("Botando Ovo...");
            }

            public void ChocarOvo()
            {
                Console.WriteLine("Chocando Ovo...");
            }

            public Cisne(string nome, DateTime dataDeNascimento, char sexo, int idade, string corPena)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = false;
                Peconhento = false;
                Rapina = false;
                CorPena = corPena;
            }
        }

        public class Arara : Ave, IOviparo, IVoar
        {
            public int AltitudeMaximaEmMetros { get; set; }
            public double VelocidadeDoVoo { get; set; }

            public void BotarOvo()
            {
                Console.WriteLine("Botando Ovo...");
            }

            public void ChocarOvo()
            {
                Console.WriteLine("Chocando Ovo...");
            }

            public void Voar()
            {
                Console.WriteLine("Voando...");
            }

            public Arara(string nome, DateTime dataDeNascimento, char sexo, int idade, string corPena, int altitudeMaximaEmMetros, double velocidadeDoVoo)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = false;
                Peconhento = false;
                Rapina = false;
                CorPena = corPena;
                AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
                VelocidadeDoVoo = velocidadeDoVoo;
            }
        }

        public class DragaoDeComodo : Reptil, IOviparo
        {
            public void BotarOvo()
            {
                Console.WriteLine("Botando Ovo...");
            }

            public void ChocarOvo()
            {
                Console.WriteLine("Chocando Ovo...");
            }

            public DragaoDeComodo(string nome, DateTime dataDeNascimento, char sexo, int idade)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = true;
                Peconhento = true;
                TemEscamas = true;
                TemCasco = false;
            }
        }

        public class Lontra : Mamifero, IAquatico
        {
            public bool ViveEmTerra { get; set; }
            public bool Mergulha { get; set; }
            public bool ViveEmAguaDoce { get; set; }

            public Lontra(string nome, DateTime dataDeNascimento, char sexo, int idade, int quantidadeMamas, string corPelo)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = true;
                Peconhento = false;
                QuantidadeMamas = quantidadeMamas;
                TemPelos = true;
                CorPelo = corPelo;
                ViveEmTerra = true;
                Mergulha = true;
                ViveEmAguaDoce = true;
            }
        }

        public class Pinguim : Ave, IOviparo
        {
            public void BotarOvo()
            {
                Console.WriteLine("Botando Ovo...");
            }

            public void ChocarOvo()
            {
                Console.WriteLine("Chocando Ovo...");
            }

            public Pinguim(string nome, DateTime dataDeNascimento, char sexo, int idade, string corPena)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = true;
                Peconhento = false;
                Rapina = false;
                CorPena = corPena;
            }
        }

        public class Coruja : Ave, IOviparo, IVoar
        {
            public int AltitudeMaximaEmMetros { get; set; }
            public double VelocidadeDoVoo { get; set; }

            public void BotarOvo()
            {
                Console.WriteLine("Botando Ovo...");
            }

            public void ChocarOvo()
            {
                Console.WriteLine("Chocando Ovo...");
            }

            public void Voar()
            {
                Console.WriteLine("Voando...");
            }

            public Coruja(string nome, DateTime dataDeNascimento, char sexo, int idade, string corPena, int altitudeMaximaEmMetros, double velocidadeDoVoo)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = true;
                Peconhento = false;
                Rapina = true;
                CorPena = corPena;
                AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
                VelocidadeDoVoo = velocidadeDoVoo;
            }
        }

        public class Elefante : Mamifero
        {
            public Elefante(string nome, DateTime dataDeNascimento, char sexo, int idade, int quantidadeMamas, string corPelo)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = false;
                Peconhento = false;
                QuantidadeMamas = quantidadeMamas;
                TemPelos = true;
                CorPelo = corPelo;
            }
        }

        public class Jacare : Reptil, IOviparo, IAquatico
        {
            public bool ViveEmTerra { get; set; }
            public bool Mergulha { get; set; }
            public bool ViveEmAguaDoce { get; set; }

            public void BotarOvo()
            {
                Console.WriteLine("Botando Ovo...");
            }

            public void ChocarOvo()
            {
                Console.WriteLine("Chocando Ovo...");
            }

            public Jacare(string nome, DateTime dataDeNascimento, char sexo, int idade)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = true;
                Peconhento = false;
                TemEscamas = true;
                TemCasco = false;
                ViveEmTerra = true;
                Mergulha = true;
                ViveEmAguaDoce = true;
            }
        }
        
        public class Ornintorrinco : Mamifero, IOviparo, IAquatico
        {
            public bool ViveEmTerra { get; set; }
            public bool Mergulha { get; set; }
            public bool ViveEmAguaDoce { get; set; }

            public void BotarOvo()
            {
                Console.WriteLine("Botando Ovo...");
            }

            public void ChocarOvo()
            {
                Console.WriteLine("Chocando Ovo...");
            }

            public Ornintorrinco(string nome, DateTime dataDeNascimento, char sexo, int idade, int quantidadeMamas, string corPelo)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Sexo = sexo;
                Idade = idade;
                Carnivoro = true;
                Peconhento = true;
                QuantidadeMamas = quantidadeMamas;
                TemPelos = true;
                CorPelo = corPelo;
                ViveEmTerra = true;
                Mergulha = true;
                ViveEmAguaDoce = true;
            }
        }
    }
}
