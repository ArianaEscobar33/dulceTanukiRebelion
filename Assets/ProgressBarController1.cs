using UnityEngine;
using UnityEngine.UI;

public class ProgressBarController1 : MonoBehaviour
{
    public Slider progressBar;
    //public Image avisoCazadorImage; // Agrega una referencia a la imagen de aviso en el Inspector.

    private float tiempoPresionado = 0f;
    private bool teclaAbajoPresionada = false;
    //private bool avisoCazadorShown = false;
    
     [Header("Animacion")]
    public Animator anim;
    public SpriteRenderer spriteR;
    public Rigidbody2D cuerpoRigido;

    void Start()
    {
        anim = GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        teclaAbajoPresionada = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        if (teclaAbajoPresionada)
        {
            cuerpoRigido.velocity = new Vector2(0,0);
            tiempoPresionado += Time.deltaTime;
            teclaAbajoPresionada = true;
        }
        else
        {
            tiempoPresionado = 0f;
            teclaAbajoPresionada = false;
        }

        if (teclaAbajoPresionada)
        {
            progressBar.value = tiempoPresionado / 7f;

            // Verifica si el valor del slider alcanza su máximo (1.0f).
            //if (progressBar.value >= 1.0f && !avisoCazadorShown)
             if (progressBar.value >= 1.0f)
            {
                teclaAbajoPresionada=false;
                // Activa la imagen de aviso del cazador.
                //avisoCazadorImage.gameObject.SetActive(true);
                
                //avisoCazadorShown = true; // Marca que se ha mostrado el aviso.
            }
        }
        else
        {
            progressBar.value = 0f;
            teclaAbajoPresionada=false;
            // Si la tecla se suelta, oculta la imagen de aviso.
            //avisoCazadorImage.gameObject.SetActive(false);
            //avisoCazadorShown = false;
        }

         anim.SetBool("teclaAbajoPresionada",teclaAbajoPresionada);

       

         // Animación especial cuando la tecla "S" o la flecha abajo está presionada
   //if (teclaAbajoPresionada)
    //{
      //  cuerpoRigido.velocity = new Vector2(0,0);
    //}
    }

     public bool EnAnimacionEspecial()
{
    return anim.GetCurrentAnimatorStateInfo(0).IsName("Player_bambu");
}


}
