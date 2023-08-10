using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos2 : MonoBehaviour
{
    public int PuntosTotales{ get { return puntosTotales; } }
    private int puntosTotales;
    public void sumarPuntos(int puntosaSumar)
    {
        puntosTotales += puntosaSumar;
        Debug.Log(puntosTotales);
    }
}
