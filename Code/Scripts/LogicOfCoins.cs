using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOfCoins : MonoBehaviour
{
    //float rotationSpeed = 100f;
    float speed = 1.0f;

    void Start()
    {
        
    }


    void Update()
    {
        transform.position += -transform.forward * speed * Time.deltaTime;
    }
}
