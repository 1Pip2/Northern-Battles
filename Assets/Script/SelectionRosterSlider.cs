using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionRosterSlider : MonoBehaviour
{
    public Transform slider;
    Vector3 mousePos;
    Vector3 mousePosOnClick;
    Vector3 sliderPosOnClick;
    bool mouseDown;
    void OnMouseDown() {
        mousePosOnClick = mousePos;
        sliderPosOnClick = slider.position;
        mouseDown = true;
    }

    void OnMouseUp() {
        mouseDown = false;
    }

    void FixedUpdate() {
        mousePos = Input.mousePosition;
        if (mouseDown) {
            float newXPos = sliderPosOnClick.x + (mousePos.x - mousePosOnClick.x) / 50;
            if (newXPos >= 1.65f) {
                slider.position = new Vector3(1.65f, slider.position.y, slider.position.z);
            } else if (newXPos <= -17.8f) {
                slider.position = new Vector3(-17.8f, slider.position.y, slider.position.z);
            } else {
                slider.position = new Vector3(newXPos, slider.position.y, slider.position.z);
            }

        }
    }
}
