using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButtomScript : MonoBehaviour
{
    public Image img;
    public Sprite buttonOn;
    public Sprite buttonOff;
    bool isOn = true;
    public MusicPlayer audioManager;

    void Update() {
        audioManager.muted = !isOn;
    }

    public void ButtonPressed() {
        isOn = !isOn;
        if (isOn) {
            img.overrideSprite = buttonOn;
        } else {
            img.overrideSprite = buttonOff;
        }
    }
}
