using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTownReturnButton : MonoBehaviour {
    public GameObject returnButton;
    public GameObject blurr;
    public GameObject inventoryMenu;
    public GameObject inventoryButton;
    public void ButtonPressed() {
        blurr.active = false;
        returnButton.active = false;
        inventoryMenu.active = false;
        inventoryButton.active = true;
    }
}
