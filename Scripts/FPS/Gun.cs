using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (AmmoCount.LoadedAmmo >= 1)
            { 
            AudioSource gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            GetComponent<Animation>().Play("GunShot");
            AmmoCount.LoadedAmmo -= 1;
        }

        }
    }
}
