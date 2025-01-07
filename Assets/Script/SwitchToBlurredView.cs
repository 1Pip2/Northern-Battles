using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToBlurredView : MonoBehaviour {
    public GameObject returnButton;
    public GameObject blurr;
    public GameObject inventoryButton;
    public void OnMouseUp() {
        blurr.active = true;
        returnButton.active = true;
        inventoryButton.active = false;
    }
}
