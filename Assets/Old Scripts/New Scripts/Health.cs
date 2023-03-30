using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int currenthealth;
    public int maxHealth;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    //set Max Health
    public void SetMaxHealth(int health) {
        maxHealth = health;
    }
    //Set Set Current Health
    public void SetCurrentHealth(int health) {
        currenthealth = health;
    }

    private void Update() {

        //Checks If current health  is greater than maxhealth
        if(currenthealth > maxHealth) {
            currenthealth = maxHealth;
        }

        //updates UI
        for (int i = 0; i < hearts.Length; i++) {

            if (i < currenthealth) {
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
            }


            if(i < maxHealth) {
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
        }
    }


}
 
