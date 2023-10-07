using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPersonaje : MonoBehaviour
{

    public float velocidadMovimiento;
    public Rigidbody2D elRB;
    private bool dobleSalto;
    public float fuerzaSalto;

    private bool esElPiso;
    public Transform puntoDetectaPiso;
    public LayerMask esPiso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elRB.velocity = new Vector2( velocidadMovimiento* Input.GetAxisRaw ("Horizontal"), elRB.velocity.y );
    
        esElPiso = Physics2D.OverlapCircle(puntoDetectaPiso.position,2f,esPiso);

      if(esElPiso)
        {
           dobleSalto = true;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if(esElPiso)
            {
             elRB.velocity = new Vector2(elRB.velocity.x, fuerzaSalto);
            } else 
            {
                if(dobleSalto)
                {
                  elRB.velocity = new Vector2(elRB.velocity.x, fuerzaSalto);  
                  dobleSalto = false;
                }
            }
        }
    }
}
