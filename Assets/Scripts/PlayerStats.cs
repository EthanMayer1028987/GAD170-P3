using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{

    public HPBar hpBar;

    public TextMeshProUGUI LivesDisplay;

    // PLAYER STATS // 

    public float maxHP = 100f;
    public float currentHP = 100f;

    public bool burning = false;
    public bool submerged = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.SetValue(currentHP);

        LivesDisplay.text = "LIVES " + EventBus.Current.ReturnLives() + "";

        if (burning == true) {
            TakeDamage(0.05f);
        }

        if (submerged == true)
        {
            if (currentHP < maxHP)
            {
                Heal(0.05f);
            }
            if (currentHP > maxHP)
            {
                currentHP = maxHP;
            }
        }

        // HEAL BUTTON
        if (Input.GetKeyDown("e"))
        {
            if(currentHP < maxHP)
            {
                Heal(20f);
            }
            if (currentHP > maxHP){
                currentHP = maxHP;
            }
        }

        // DAMAGE TEST BUTTON
        if (Input.GetKeyDown("q"))
        {
            if (currentHP > 0)
            {
                TakeDamage(10f);
            }
            
        }

    }

    void TakeDamage(float damage) {
        if(currentHP > 0)
        {
            currentHP -= damage;
            hpBar.SetValue(currentHP);
        }
    }

    void Heal(float healing) {
        currentHP += healing;
        hpBar.SetValue(currentHP);
    }
}
