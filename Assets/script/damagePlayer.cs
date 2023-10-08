using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagePlayer : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Puedes cambiar "Player" por la etiqueta del objeto con el que quieres colisionar.
        {
            Debug.Log("chocaron");
        }
    }
    }

