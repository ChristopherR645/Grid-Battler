using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    

    //Set Enemy Health
    public void SetHealth(int health) {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }


    //Set Enemy Max Health
    public void SetMaxHealth(int health) {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }
}
