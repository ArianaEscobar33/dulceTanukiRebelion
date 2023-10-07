using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPersonaje : MonoBehaviour
{

    public float velocidadMovimiento;
    public Rigidbody2D elRB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elRB.velocity = new Vector2( velocidadMovimiento* Input.GetAxis ("Horizontal"), elRB.velocity.y );
    }
}
