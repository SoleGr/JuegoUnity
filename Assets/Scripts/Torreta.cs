using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    public Transform playerTransform;
    public float speedToLook = 20f;
    private float tiempoEsperaRestante;
    public float tiempoEntreBalas = 5.0f;
    public GameObject bala;

    void Start()
    {
        ResetTimerDisparos();
    }

    void Update()
    {
        
        TemporizadorDisparos();
    }

    private void LookAtPlayer()
    {
        Vector3 targetOrientation = playerTransform.position - transform.position;
        Debug.DrawRay(transform.position, targetOrientation, Color.green);

        Quaternion targetOrientationQuaternium = Quaternion.LookRotation(targetOrientation);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetOrientationQuaternium, speedToLook * Time.deltaTime);
            
    }

    private void TemporizadorDisparos()
    {
        LookAtPlayer();
        tiempoEsperaRestante -= Time.deltaTime;

        if (tiempoEsperaRestante <= 0)
        {
            Disparar();
            ResetTimerDisparos();
        }
    }

    private void Disparar()
    {
        Instantiate(bala, transform.position, transform.rotation);
    }
    
    private void ResetTimerDisparos(){
        tiempoEsperaRestante = tiempoEntreBalas; 
    }

}
