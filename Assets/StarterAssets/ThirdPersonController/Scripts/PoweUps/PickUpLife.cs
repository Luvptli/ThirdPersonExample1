using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpLife : MonoBehaviour, IPowerUp
{
    [SerializeField]
    int healthAmount = 1;
    public void PickUpPowerUp(GameObject other)
    {
        if (other.TryGetComponent<HealthSystem>(out HealthSystem health))
        {
            health.ModifyHealth(healthAmount);
        }
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
