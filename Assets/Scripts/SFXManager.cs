using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;

    public GameObject coinParticles;

    void awake(){
        if (instance == null){
            instance = this;

        }

    }
    public void ShowCoinParticles(GameObject obj){
         GameObject particles = Instantiate(coinParticles, obj.transform.position, Quaternion.identity); 
            GameObject Tape = GameObject.Find("Tape");
            particles.transform.SetParent(Tape.transform);
    }

}
