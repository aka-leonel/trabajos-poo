namespace ejercicio4
{
    internal class Animal
    {
        private int id;
        private string nombre;
        private string sonido;
        private static int nextId = 0;
        public Animal(string nombre) {
            this.nombre = nombre;
            this.id = nextId;
            nextId++;
            sonido = $"{nombre}Sonido.mp3";
        }
        public void EmitirSonido()
        {
            // emitir sonido
            Console.WriteLine($"reproduciendo {sonido}");
        }
    }
}