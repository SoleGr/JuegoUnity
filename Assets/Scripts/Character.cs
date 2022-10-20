using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int life;
    public float RotateSpeed = 5f;
    float movementSpeed = 5f;
    Vector3 posicionInicial;
    public Animator animacion;

    void Start()
    {
        life = 100;
        posicionInicial = transform.position;

    }

    void Update()
    {
        float movimientoX = Input.GetAxis("Horizontal");
        float movimientoY = Input.GetAxis("Vertical");
        transform.Translate(movimientoX * Time.deltaTime * movementSpeed, 0, movimientoY * Time.deltaTime * movementSpeed);

        if (Input.GetKey(KeyCode.S))
            animacion.SetBool("mueveAtras", true);
        else
            animacion.SetBool("mueveAtras", false);

        if (Input.GetKey(KeyCode.W))
            animacion.SetBool("mueveAdelante", true);
        else
            animacion.SetBool("mueveAdelante", false);

        if (Input.GetKey(KeyCode.A))
            animacion.SetBool("mueveIzquierda", true);
        else
            animacion.SetBool("mueveIzquierda", false);

        if (Input.GetKey(KeyCode.D))
            animacion.SetBool("mueveDerecha", true);
        else
            animacion.SetBool("mueveDerecha", false);


        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);

        
        if(transform.position.y < -10) 
        {
            Respawn();
        }

        HealWithTime();
    }

    private void Respawn()
    {
        transform.position = posicionInicial;
    }

    private void HealWithTime()
    {
        if(life < 100)
        {
            life++;
        }
    }
}
