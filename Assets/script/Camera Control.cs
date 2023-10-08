using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public Transform fondoAtras, fondoMedio, fondoAdelante,fondo;
    private Vector2 ultPos;
    public float minAlt, maxAlt;

    void Start()
    {
        ultPos = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, minAlt, maxAlt), transform.position.z);
        Vector2 cantMovCam = new Vector2(transform.position.x - ultPos.x,transform.position.y - ultPos.y);
        fondo.position = fondo.position + new Vector3(cantMovCam.x, cantMovCam.y, 0f);
        fondoAtras.position += new Vector3(cantMovCam.x, cantMovCam.y, 0f)*1.1f;
        fondoMedio.position += new Vector3(cantMovCam.x, cantMovCam.y, 0f)*1f;
        fondoAdelante.position += new Vector3(cantMovCam.x, cantMovCam.y, 0f)*1.25f;  
        //suelo.position += new Vector3(cantMovCam.x, 0f, 0f);
        ultPos = transform.position;
    }
}
