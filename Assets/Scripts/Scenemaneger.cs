﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions; 

public class Scenemaneger : MonoBehaviour
{
    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-2f, 0f ,0f);
    [SerializeField]
    private Transform Tape = null;

    void Awake(){
        Assert.IsNotNull(Tape);  
    }

    void Start()

    {
        
    }

   
    void Update()
    {
       Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
    }
}
