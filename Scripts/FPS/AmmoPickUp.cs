using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {

        if(AmmoCount.LoadedAmmo == 0)
        {
            AmmoCount.LoadedAmmo += 10;
            this.gameObject.SetActive(false);
        }
        else
        {
            AmmoCount.CurrentAmmo += 10;
            this.gameObject.SetActive(false);
        }
       
    }
}
