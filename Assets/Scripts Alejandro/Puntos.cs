using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Puntos : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI puntos;
    private void Update(){
        puntos.text = gameManager.PuntosTotales.ToString();
    }
}

