using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{

    public static int CurrentAmmo;
    public int InternalAmmo;
    public GameObject AmmoDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalAmmo = CurrentAmmo;
        AmmoDisplay.GetComponent<Text>().text = " " + InternalAmmo;
    }
}

