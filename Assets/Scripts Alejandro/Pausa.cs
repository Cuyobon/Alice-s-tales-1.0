using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject MenuPausa;
    private bool PausaActiva;
    // Start is called before the first frame update
    void Start()
    {
        MenuPausa.SetActive(false);
        PausaActiva = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausaActiva == false)
            {
                pausa();
            }
            else
            {
                reanudar();
            }
        }
    }

    private void pausa()
    {
        PausaActiva = true;
        Time.timeScale = 0f;
        MenuPausa.SetActive(true);
    }

    public void reanudar()
    {
        PausaActiva = false;
        Time.timeScale = 1f;
        MenuPausa.SetActive(false);
    }

    public void reiniciar()
    {
        PausaActiva = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void salir()
    {
        Application.Quit();
        Debug.Log("Saliendo Sel Juego");
    }
}