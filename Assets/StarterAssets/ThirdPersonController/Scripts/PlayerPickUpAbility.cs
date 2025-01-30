using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpAbility : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //out para almacenar información 
        if(other.TryGetComponent<IPowerUp>(out IPowerUp pickUpPowerup))
        {
            pickUpPowerup.PickUpPowerUp(this.gameObject);
            //Destruye siempre lo que coge
            //Destroy (other.gameObject);
        }
    }
}
