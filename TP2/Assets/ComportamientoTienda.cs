using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Linq;
using Random = System.Random;

public class ComportamientoTienda : MonoBehaviour
{

    public class ItemTienda
    {
        public string Nombre { get; set; }
        public int Costo { get; set; }

        public ItemTienda(string nombre, int costo)
        {
            Nombre = nombre;
            Costo = costo;
        }

    }


    void Start()
    {

        Random rnd = new Random();
        Dictionary<string, int> Tienda = new Dictionary<string, int>();
        for (int i = 0; i < 10000; i++)
        {
            int longitud = 7;
            Guid miGuid = Guid.NewGuid();
            string item = miGuid.ToString().Replace("-", string.Empty).Substring(0, longitud);
            int precio = rnd.Next(300, 1000);
            
            Tienda.Add(item, precio);

        }


        Debug.Log("La tienda posee " + Tienda.Count + " productos");

        foreach (KeyValuePair<string, int> ItemTienda in Tienda)
        {
            
            Debug.Log(ItemTienda.Key + " ------ " + ItemTienda.Value);
                  
        }

    }

   
    void Update()
    {

    }
  
}

