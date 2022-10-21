using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{
    public float tiempoParaDestruir = 4;

    void Start()
    {
        Destroy(gameObject,tiempoParaDestruir);
    }

}
