using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadusuario;
    public Text mitexto;

    void Start()
    {
        if (edadusuario >= 18)
        {
            mitexto.text = "Es mayor de edad.";
            Debug.Log("Es mayor de edad.");
        }

        else
        {
            mitexto.text = "No es mayor de edad.";
            Debug.Log("No es mayor de edad.");
        }
    }
}
