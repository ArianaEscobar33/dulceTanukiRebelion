using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ganaste : MonoBehaviour
{
    public string ganar;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //ControlPlayer controlPlayer = other.GetComponent<ControlPlayer>();

                Debug.Log("gano");
                SceneManager.LoadScene(ganar);
            
        }
    }
}
