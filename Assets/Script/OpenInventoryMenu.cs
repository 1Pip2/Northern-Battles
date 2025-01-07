using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventoryMenu : MonoBehaviour
{
    public GameObject inventoryMenu;
    void OnMouseUp() {
        inventoryMenu.active = true;
    }
}
