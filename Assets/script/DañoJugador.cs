using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DañoJugador : MonoBehaviour
{
    public string perdiste;
    private bool puedeHacerDano = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && puedeHacerDano)
        {
           ProgressBarController1 progressBarController1 = other.GetComponent<ProgressBarController1>();


            // Verificar si el jugador está en la animación especial
            if (!progressBarController1.EnAnimacionEspecial())
            {
                Debug.Log("HIT");
                SceneManager.LoadScene(perdiste);
            }
        }
    }
}

