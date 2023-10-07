using UnityEngine;
using UnityEngine.UI;

public class ProgressBarController1 : MonoBehaviour
{
    public Slider progressBar;
    public Image avisoCazadorImage; // Agrega una referencia a la imagen de aviso en el Inspector.

    private float tiempoPresionado = 0f;
    private bool teclaPresionada = false;
    private bool avisoCazadorShown = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tiempoPresionado += Time.deltaTime;
            teclaPresionada = true;
        }
        else
        {
            tiempoPresionado = 0f;
            teclaPresionada = false;
        }

        if (teclaPresionada)
        {
            progressBar.value = tiempoPresionado / 2.0f;

            // Verifica si el valor del slider alcanza su máximo (1.0f).
            if (progressBar.value >= 1.0f && !avisoCazadorShown)
            {
                // Activa la imagen de aviso del cazador.
                avisoCazadorImage.gameObject.SetActive(true);
                avisoCazadorShown = true; // Marca que se ha mostrado el aviso.
            }
        }
        else
        {
            progressBar.value = 0f;

            // Si la tecla se suelta, oculta la imagen de aviso.
            avisoCazadorImage.gameObject.SetActive(false);
            avisoCazadorShown = false;
        }
    }
}
