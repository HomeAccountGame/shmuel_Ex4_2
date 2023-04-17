using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getVal : MonoBehaviour
{
    [SerializeField] int value = -1;
    public handle_switch fo;
    public cards val;
    public GameObject deck;
    public GameObject button;
    public GameObject card;

    public cards first;
    // Start is called before the first frame update
    void Start()
    {
        //drawCard;
        deck = GameObject.Find("deck");
        first = deck.GetComponent<cards>();
        value = first.Draw();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void switc()
    {
        int temp_val = value;
        //deck = GameObject.Find("deck");
        button = GameObject.Find("Handler");
        //cards scp = deck.GetComponent<cards>();
        handle_switch scp2 = button.GetComponent<handle_switch>();
        if (scp2.getListen())
        {
            this.value = first.getCurr();
            first.setCurr(temp_val);
            scp2.setListen();
        }
        for (int i = 0; i < 10; i++)
        {
            string temp = "card-" + i;
            card = GameObject.Find(temp);
            move scp = card.GetComponent<move>();
            if (i == temp_val)
                scp.moves();
            else
            {
                scp.movesaway();
            }
        }
    }
}
