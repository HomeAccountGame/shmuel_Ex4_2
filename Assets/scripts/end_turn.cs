using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class end_turn : MonoBehaviour
{
    [SerializeField] bool player_turn;
    [SerializeField] textField scoreField;
    public GameObject deck;
    public GameObject button;
    public GameObject com;
    public com_play turn;
    public com2_play turn2;
    public com3_play turn3;
    public string the_turn_is;
    // Start is called before the first frame update
    void Start()
    { 
        player_turn = true;
        the_turn_is = "hello player";
        scoreField.Setstring(the_turn_is);
    }
    public bool isPlayerTurn()
    {
        return player_turn;
    }
    public void end()
    {
        deck = GameObject.Find("deck");
        button = GameObject.Find("Handler");
        
        cards flag = deck.GetComponent<cards>();
        handle_switch flag2 = button.GetComponent<handle_switch>();
        if (flag.getplay() || flag2.getplay())
        {
            player_turn = false;
            float startTime = Time.time;
            Debug.Log("start time: " + startTime);
            StartCoroutine(com3Turn());
            player_turn = true;
            flag.setplay();
            flag2.setplay();
        }

    }
    IEnumerator com1Turn()
    {
        the_turn_is = "com1";
        scoreField.Setstring(the_turn_is);
        com = GameObject.Find("com1");
        turn = com.GetComponent<com_play>();
        turn.turn();
        yield return new WaitForSeconds(1);
    }
    IEnumerator com2Turn()
    {
        yield return com1Turn();
        the_turn_is = "com2";
        scoreField.Setstring(the_turn_is);
        com = GameObject.Find("com2");
        turn2 = com.GetComponent<com2_play>();
        turn2.turn();
        yield return new WaitForSeconds(1);
    }
    IEnumerator com3Turn()
    {
        yield return com2Turn();
        the_turn_is = "com3";
        scoreField.Setstring(the_turn_is);
        com = GameObject.Find("com3");
        turn3 = com.GetComponent<com3_play>();
        turn3.turn();
        yield return new WaitForSeconds(1);
        the_turn_is = "player";
        scoreField.Setstring(the_turn_is);
    }
}
