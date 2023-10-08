using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    [Header("Movimiento")]
    public float velMov;
    public float altSalto;
    private bool sePuedeDobleSalto;
    //private bool teclaAbajoPresionada;


    [Header("Componentes")]
    public Rigidbody2D cuerpoRigido;
    private bool esSuelo;
    public Transform controlSuelo;
    public LayerMask queEsSuelo;

    [Header("Animacion")]
    private Animator anim;
    private SpriteRenderer spriteR;

    public AudioSource SonidoDeSalto;
    public AudioSource SonidoCaminar;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();

        SonidoDeSalto = GetComponent<AudioSource>();
        SonidoCaminar = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // movimiento lineal
        cuerpoRigido.velocity = new Vector2(velMov * Input.GetAxis("Horizontal"),cuerpoRigido.velocity.y);
        
        if (Input.GetButtonDown("Horizontal"))
        {
           SonidoCaminar.Play(); 
        }
        // Saltos
        esSuelo = Physics2D.OverlapCircle(controlSuelo.position, .2f, queEsSuelo);
        if (esSuelo)
        {
            sePuedeDobleSalto = true;
        }
        if (Input.GetButtonDown("Jump"))
        {
            SonidoDeSalto.Play();
            if (esSuelo)
            {
                cuerpoRigido.velocity = new Vector2(cuerpoRigido.velocity.x,altSalto);
            }else{
                if (sePuedeDobleSalto)
                {
                    cuerpoRigido.velocity = new Vector2(cuerpoRigido.velocity.x,altSalto);
                    sePuedeDobleSalto = false;
                }
            }
        }
   

        if (cuerpoRigido.velocity.x <0)
        {
            spriteR.flipX=false;
        }else if (cuerpoRigido.velocity.x >0)
        {
            spriteR.flipX=true;
        }

        //Animacion
        anim.SetFloat("velMov",Mathf.Abs(cuerpoRigido.velocity.x));
        anim.SetBool("esSuelo",esSuelo);
       // anim.SetBool("teclaAbajoPresionada",teclaAbajoPresionada);

       // teclaAbajoPresionada = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);

         // Animación especial cuando la tecla "S" o la flecha abajo está presionada
   // if (teclaAbajoPresionada)
    //{
      //  cuerpoRigido.velocity = new Vector2(0,0);
    //}
    }

  //  public bool EnAnimacionEspecial()
//{
  //  return anim.GetCurrentAnimatorStateInfo(0).IsName("Player_bambu");
//}

}
