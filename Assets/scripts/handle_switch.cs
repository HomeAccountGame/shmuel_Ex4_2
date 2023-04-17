using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handle_switch : MonoBehaviour
{
    [SerializeField]
    private bool buttonPressed = false;
    [SerializeField]
    private bool play_switch = false;
    public void clicked()
    {        
        Debug.Log("start objects: ");
        buttonPressed = true;
        play_switch = true;
    }
    public bool getListen() { return buttonPressed; }
    public void setListen() { buttonPressed = false; }
    public bool getplay() { return play_switch; }
    public void setplay() { play_switch = false; }


}
