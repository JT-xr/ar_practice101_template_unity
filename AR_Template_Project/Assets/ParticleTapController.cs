using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTapController : MonoBehaviour
{
    private ParticleSystem particleActivator;

    void Start()
    {
        particleActivator = GetComponent<ParticleSystem>(); 
    }

    void Update()
    {
        if (Input.touchCount > 0){
            particleActivator.Play ();
        }

        if (particleActivator.isPlaying){
        Debug.Log ("Particles are playing");
        }
    }

    

}
