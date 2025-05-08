using UnityEngine;

public abstract class Obstaculo : MonoBehaviour
{
    public string nombre;
    public int daño;

    public virtual void AplicarDaño(Jugador jugador)
    {
        jugador.RecibirDaño(daño);
    }
}

public class Valla : Obstaculo
{
    private void Start()
    {
        nombre = "Valla";
        daño = 20;
    }
}

