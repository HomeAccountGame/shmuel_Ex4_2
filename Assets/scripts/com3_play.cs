using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class com3_play : MonoBehaviour
{
    public GameObject deck;
    public cards card;
    [SerializeField] public int value1 = -1;
    [SerializeField] public int value2 = -1;
    [SerializeField] public int value3 = -1;
    [SerializeField] public int value4 = -1;
    public GameObject num_card;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        num_card = GameObject.Find("com3-1");
        changeVal temp = num_card.GetComponent<changeVal>();
        value1 = temp.value;
        num_card = GameObject.Find("com3-2");
        temp = num_card.GetComponent<changeVal>();
        value2 = temp.value;
        num_card = GameObject.Find("com3-3");
        temp = num_card.GetComponent<changeVal>();
        value3 = temp.value;
        num_card = GameObject.Find("com3-4");
        temp = num_card.GetComponent<changeVal>();
        value4 = temp.value;
    }
    public void turn()
    {
        deck = GameObject.Find("deck");
        card = deck.GetComponent<cards>();
        int value = -1;
        if (card.getCurr() < 3)
        {
            value = card.getCurr();

        }
        else
        {
            value = card.Draw();
        }
        Debug.Log(value);

        if (value < 9)
        {
            if (value1 > value)
            {
                num_card = GameObject.Find("com3-1");
                changeVal temp = num_card.GetComponent<changeVal>();
                temp.Update_val();
                value1 = value;
            }
            else if (value2 > value)
            {
                num_card = GameObject.Find("com3-2");
                changeVal temp = num_card.GetComponent<changeVal>();
                temp.Update_val();
                value2 = value;
            }
            else if (value3 > value)
            {
                num_card = GameObject.Find("com3-3");
                changeVal temp = num_card.GetComponent<changeVal>();
                temp.Update_val();
                value3 = value;
            }
            else if (value4 > value)
            {
                num_card = GameObject.Find("com3-4");
                changeVal temp = num_card.GetComponent<changeVal>();
                temp.Update_val();
                value4 = value;
            }
        }
    }
}
