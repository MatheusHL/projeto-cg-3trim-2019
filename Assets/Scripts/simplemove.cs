﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplemove : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;
    [SerializeField]
    private float LimitTop = 4f;
    [SerializeField]
    private float LimitBottom = -4f; 
    [SerializeField]
    private float LimitLeft = -8f;
    [SerializeField]
    private float LimitRight = 8f;

    void Start()
    {
       
    }


    void Update()
    {
        float HorizontalInput = Input.GetAxisRaw("Horizontal");
        float VerticalInput = Input.GetAxisRaw("Vertical");

        Vector3 velocity = new Vector3(HorizontalInput, VerticalInput, 0f) * SpeedFactor;

        
      transform.position = transform.position + velocity * Time.deltaTime;

      if (transform.position.y < LimitBottom ) {
        transform.position =  new Vector3 (transform.position.x, LimitBottom, transform.position.z);
      }
      if (transform.position.y > LimitTop ) {
        transform.position =  new Vector3 (transform.position.x, LimitTop, transform.position.z);
      }
       if (transform.position.x < LimitLeft ) {
        transform.position =  new Vector3 (LimitLeft, transform.position.y, transform.position.z);
      }
      if (transform.position.x > LimitRight ) {
        transform.position =  new Vector3 (LimitRight, transform.position.y, transform.position.z);
      }


    }
}
