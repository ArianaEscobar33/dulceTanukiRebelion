using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarImagenes : MonoBehaviour
{
    public GameObject[] imagenes;
    public string nuevaEscena;  // Nombre de la nueva escena a cargar

    private int currentIndex = 0;

    void Start()
    {
        if (imagenes != null && imagenes.Length > 0)
        {
            for (int i = 1; i < imagenes.Length; i++)
            {
                imagenes[i].SetActive(false);
            }
            InvokeRepeating("CambiarImagen", 5f, 5f);
        }
        else
        {
            Debug.LogError("No se han asignado imágenes en el inspector.");
        }
    }

    void CambiarImagen()
    {
        imagenes[currentIndex].SetActive(false);

        currentIndex++;

        if (currentIndex < imagenes.Length)
        {
            imagenes[currentIndex].SetActive(true);
        }
        else
        {
            // Si llega a la última imagen, cargar nueva escena
            SceneManager.LoadScene(nuevaEscena);
            // Puedes detener el proceso después de cargar la nueva escena si no deseas seguir el ciclo
            CancelInvoke("CambiarImagen");
        }
    }
}
