/*
 * HUD.cs
 * By: Esther Strathy
 * 1/14/2020
 * Description: displays life hearts
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Sprite[] HeartSprite;
    public Image HeartUI;




    private void Update()
    {
        HeartUI.sprite = HeartSprite[GameManager.lives];
    }
}
