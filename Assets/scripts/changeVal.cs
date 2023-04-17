using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeVal : MonoBehaviour
{
    [SerializeField] public int value = -1;
    public GameObject deck;
    public cards first;
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        deck = GameObject.Find("deck");
        first = deck.GetComponent<cards>();
        value = first.Draw();
    }

    // Update is called once per frame
    public void Update_val()
    {
        int temp = value;
        this.value = first.getCurr();
        first.setCurr(temp);
        for (int i = 0; i < 10; i++)
        {
            string temp_name = "card-" + i;
            card = GameObject.Find(temp_name);
            move scp = card.GetComponent<move>();
            if (i == temp)
                scp.moves();
            else
            {
                scp.movesaway();
            }
        }
    }
}
