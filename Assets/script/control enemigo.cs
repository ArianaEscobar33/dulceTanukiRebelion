using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlenemigo : MonoBehaviour
{
    public float velMov;
    public Transform puntoDer, puntoIzq;
    private bool movimientoDer;

    private Rigidbody2D rigidbody;
    public SpriteRenderer theSR;

    public float tiempoMov, tiempoEspera;
    private float movCount, esperaCount; 

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        puntoDer.parent = null;
        puntoIzq.parent = null;

        movimientoDer = true;
        movCount = tiempoMov;
    }

    // Update is called once per frame
    void Update()
    {
       if (movCount > 0)
       {
        movCount -= Time.deltaTime;
         if (movimientoDer)
       {
        rigidbody.velocity = new Vector2(velMov, rigidbody.velocity.y);
        theSR.flipX = true;

        if(transform.position.x > puntoDer.position.x)
        {
            movimientoDer = false;
        }

       } else 
       {
        rigidbody.velocity = new Vector2(-velMov, rigidbody.velocity.y);
        theSR.flipX = false;

        if(transform.position.x < puntoIzq.position.x)
        {
            movimientoDer = true;
        }

       }

       if (movCount <= 0)
       {
         esperaCount  = Random.Range(tiempoEspera * .75f, tiempoEspera * 1.25f);
       }
    } else if (esperaCount > 0)
       {
        esperaCount -= Time.deltaTime;
        rigidbody.velocity = new Vector2(0f, rigidbody.velocity.y);

        if (esperaCount <= 0)
       {
         movCount  = Random.Range(tiempoMov * .75f, tiempoEspera * 1.25f);
       }
       }

       
    }
}
