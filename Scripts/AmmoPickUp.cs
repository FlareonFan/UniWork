using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        GlobalAmmo.CurrentAmmo += 10;
        this.gameObject.SetActive(false);
    }
}
