using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //variables for the game
    public int maxHealth;           //determines max amount of health the player can have
    public int currentHealth;       //tracks current heatlh of the player

    public GameObject hp1;          
    public GameObject hp2;          
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 2;              //set max health to two
        currentHealth = maxHealth;  //set current health to max health
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;                    //lower health

        if (currentHealth ==2)
        {
            hp2.SetActive(false);
        }
        if (currentHealth == 1)
        {
            hp1.SetActive(false);
        }
        if (currentHealth <= 0)                     //if health equal zero
        {
            SceneManager.LoadScene("GameOver");     //go to GameOver Scene
        }
    }
}
