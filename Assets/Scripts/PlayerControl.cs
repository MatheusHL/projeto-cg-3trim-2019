﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    void Start()
    {
        
    }

    
    void Update()
    {
        void OnTriggerEnter2D(Collider2D other){
            if (other.gameObject.CompareTag("Coin")){
                SFXManager.instance.ShowCoinParticles (other.gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
