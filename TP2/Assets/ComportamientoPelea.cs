using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoPelea : MonoBehaviour
{
    Personaje p1 = new Personaje("Ryu", 100, 10, 16, 4);
    Personaje p2 = new Personaje("Ken", 90, 12, 13, 6);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(p1.Nombre + ", tenes " + p1.Vida + " puntos de vida, " + p1.Defensa + " puntos de defensa, " + p1.Fuerza + " puntos de fuerza y tu arma es un martillo");
        Debug.Log(p2.Nombre + ", tenes " + p2.Vida + " puntos de vida, " + p2.Defensa + " puntos de defensa, " + p2.Fuerza + " puntos de fuerza y tu arma es un palo de golf");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Se presiono la tecla W");
            p1.pegar(p2, p1);
            Debug.Log(p2.Nombre + " te quedan " + p2.Vida + " puntos de vida");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Se presiono la tecla P");
            p2.pegar(p1, p2);
            Debug.Log(p1.Nombre + " te queda " + p1.Vida + " puntos de vida");
        }

    }


    public class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Defensa { get; set; }
        public int Fuerza { get; set; }
        public int Arma { get; set; }

        public Personaje(string nombre, int vida, int defensa, int fuerza, int arma)
        {
            Nombre = nombre;
            Vida = vida;
            Defensa = defensa;
            Fuerza = fuerza;
            Arma = arma;
        }

        public void pegar(Personaje unPersonaje, Personaje otroPersonaje)
        {
            unPersonaje.Vida = ((unPersonaje.Vida + unPersonaje.Defensa) - ((otroPersonaje.Fuerza) + (otroPersonaje.Arma)));
            if (unPersonaje.Vida <= 0)
            {
                Debug.Log("GAME OVER... " + otroPersonaje.Nombre + " GANÓ EL COMMBATE");

            }
        }

    }
}
