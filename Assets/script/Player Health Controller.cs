using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public int currentHealth,maxHelth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHelth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage()
    {
        currentHealth--;
        if(currentHealth <= 0)
        {
          gameObject.SetActive(false);
        }
    }
}
