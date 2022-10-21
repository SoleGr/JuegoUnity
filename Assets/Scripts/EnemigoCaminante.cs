using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoCaminante : MonoBehaviour
{
    public Transform playerTransform;

    public float speed = 3;

    void Start()
    {
    }

    void Update()
    {
        MoveTowards();
    }

    private void MoveTowards()
    {
        float distance = Vector3.Distance(playerTransform.position, transform.position);

        if (distance >= 2)
        {
            Vector3 direction = (playerTransform.position - transform.position).normalized;
            transform.position += speed * direction * Time.deltaTime;
        }
    }
}
