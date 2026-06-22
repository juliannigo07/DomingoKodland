using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Variables 
    // Numeros enteros
    public int EdadJulian = 21;

    // Numeros decimales
    float Corinne = 1.5f;

    //Booleanos      //bool 
    bool Numero = true;

    //Strings
    string Colombia = "Hola";




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("La edad de Julian es: " + EdadJulian);
    }
}
