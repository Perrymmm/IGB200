using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Image Hpbar;

    public float hp;
    public float Starthp;

    public GameObject GameOverUI;
    public GameObject InGameUI;

    public void TakeDamage(int damage)
    {
        hp = hp - damage;
        Hpbar.fillAmount = hp / Starthp;
    }


    //Regen Is Bugged
    public void RegenHp(int regen)
    {
        if (hp > 100)
        {
            hp = 100;
        }
        else
        {
            hp = hp + regen;
            Hpbar.fillAmount = hp + regen;

        }


    }

    public void Update()
    {

        if (hp == 0 || hp < 0)
        {
            GameOverUI.gameObject.SetActive(true);
            InGameUI.gameObject.SetActive(false);
        }
    }

}
