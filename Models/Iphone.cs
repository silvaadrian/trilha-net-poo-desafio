namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        private string _modelo;

        private string _imei;

        private int _memoria;

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} via Iphone");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Celular de número {Numero}, Modelo {_modelo}, IMEI {_imei}, Memoria {_memoria} IPHONE");
        }
    }
}
