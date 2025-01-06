using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTownReturnButton : MonoBehaviour {
    public GameObject returnButton;
    public GameObject blurr;
    public void ButtonPressed() {
        blurr.active = false;
        returnButton.active = false;
    }
}
