using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour, IPowerUp
{
    public void PickUpPowerUp(GameObject other)
    {
        Debug.Log("Recoger AMMO");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
