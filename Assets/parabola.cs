using System.Collections;
using UnityEngine;

public class TiroParabolico : MonoBehaviour
{
    public float velocidadInicial = 10f; // Velocidad inicial del proyectil
    public float anguloLanzamiento = 45f; // Ángulo de lanzamiento en grados
    public float gravedad = 9.81f; // Aceleración debido a la gravedad

    private Vector3 posicionInicial;
    private float tiempoTranscurrido;

    void Start()
    {
        // Guardamos la posición inicial del proyectil
        posicionInicial = transform.position;

        // Convertimos el ángulo de lanzamiento a radianes
        float radianes = anguloLanzamiento * Mathf.Deg2Rad;

        // Calculamos las componentes horizontal y vertical de la velocidad inicial
        float velocidadInicialX = velocidadInicial * Mathf.Cos(radianes);
        float velocidadInicialY = velocidadInicial * Mathf.Sin(radianes);

        // Calculamos el tiempo total de vuelo usando la fórmula t = 2 * V0y / g
        float tiempoTotalVuelo = (2f * velocidadInicialY) / gravedad;

        // Calculamos la distancia máxima usando la fórmula d = V0x * t
        float distanciaMaxima = velocidadInicialX * tiempoTotalVuelo;

        // Establecemos el tiempo transcurrido inicialmente a cero
        tiempoTranscurrido = 0f;
    }

    void Update()
    {
        // Actualizamos el tiempo transcurrido
        tiempoTranscurrido += Time.deltaTime;

        // Calculamos la posición actual del proyectil usando el método de Euler
        float x = posicionInicial.x + (velocidadInicial * Mathf.Cos(anguloLanzamiento * Mathf.Deg2Rad)) * tiempoTranscurrido;
        float y = posicionInicial.y + (velocidadInicial * Mathf.Sin(anguloLanzamiento * Mathf.Deg2Rad) - (gravedad * tiempoTranscurrido * tiempoTranscurrido) / 2f);

        // Actualizamos la posición del objeto en Unity
        transform.position = new Vector3(x, y, 0f);
    }
}
