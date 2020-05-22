namespace PrimeiroPoo
{
    public class Personagem
    {
        public string nome = "Peter Parker";
        public int idade = 17;
        public string armadura ;
        public float vida = 100f;

        public string Atacar()
        {
            return "o personagem atacou!";
        }
        public float CalcularDano(float dano){
            return vida - dano;
        }


    }
}