using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 5;
    [SerializeField]
    int currentHealth = 2;

    Animator animator;

    private void Awake()
    {
        animator =GetComponent<Animator>();
        UpdateAnimator();
    }

    public void ModifyHealth (int amount)
    {
        if (currentHealth + amount <= 0)
        {
            //currentHealth =0;
            Debug.Log("MUERTO");
            //Destroy(gameObject);
            // con esto el objeto se crea en el punto donde se inició pero la cámara deja de seguirlo
            // Instantiate(gameObject, Vector3.zero, Quaternion.identity);
        }

        else if (currentHealth == maxHealth && amount > 0)
        {
            Debug.Log("Tu vida está al máximo");
        }

        else if (currentHealth + amount > maxHealth)
        {
            Debug.Log("Vida a tope");
            currentHealth = maxHealth;
        }
        else //(currentHealth + amount < maxHealth)
        {
            Debug.Log("Recupera " + amount + " de vida");
            currentHealth += amount;
        }
    }

    void UpdateAnimator()
    {
        animator.SetInteger("Health", currentHealth);
    }
}
