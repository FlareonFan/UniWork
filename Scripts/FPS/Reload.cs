using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
  //  public GameObject CrossObject;
  //  public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int ReloadAvailable;
    public Gun GunComponent;

    void Start()
    {
        GunComponent = GetComponent<Gun>();
    }

    void Update()
    {
        ClipCount = AmmoCount.LoadedAmmo;
        ReserveCount = AmmoCount.CurrentAmmo;

        if (ReserveCount == 0)
        {
            ReloadAvailable = 0;
        }
        else
        {
            ReloadAvailable = 10 - ClipCount;
        }

        if (Input.GetButtonDown("Reload"))
        {
            if (ReloadAvailable >= 1)
            {
                if (ReserveCount <= ReloadAvailable)
                {
                    AmmoCount.LoadedAmmo += ReserveCount;
                   AmmoCount.CurrentAmmo -= ReserveCount;
                    ActionReload();
                }
                else
                {
                    AmmoCount.LoadedAmmo += ReloadAvailable;
                    AmmoCount.CurrentAmmo -= ReloadAvailable;
                    ActionReload();
                }
            }
            StartCoroutine(EnableScripts());

        }
    }

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.1f);
        GetComponent<Gun>().enabled = true;
       // CrossObject.SetActive(true);
       // MechanicsObject.SetActive(true);
    }

    void ActionReload()
    {
        GetComponent<Gun>().enabled = false;
       // CrossObject.SetActive(false);
       // MechanicsObject.SetActive(false);
        GetComponent<Animation>().Play("Reload");
    }
}