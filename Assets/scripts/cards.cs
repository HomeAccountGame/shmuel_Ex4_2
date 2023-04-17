using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cards : MonoBehaviour
{

    private List<int> _cards = new List<int>();
    public int current;
    [SerializeField]
    private bool play_draw = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            _cards.Add(0);
            _cards.Add(1);
            _cards.Add(2);
        }

        for (int i = 0; i < 5; i++)
        {
            _cards.Add(3);
            _cards.Add(4);
            _cards.Add(5);
        }

        for (int i = 0; i < 6; i++)
        {
            _cards.Add(6);
            _cards.Add(7);
            _cards.Add(8);
            _cards.Add(9);
        }
        _cards.Add(9);

        for (int i = 0; i < _cards.Count; i++)
        {
            int randomIndex = UnityEngine.Random.Range(i, _cards.Count);
            int temp = _cards[i];
            _cards[i] = _cards[randomIndex];
            _cards[randomIndex] = temp;
        }
        Debug.Log(_cards.Count);
    }

    public int Draw()
    {
        if (_cards.Count == 0)
        {
            return -1;
        }

        int card = _cards[0];
        _cards.RemoveAt(0);
        current = card;

        return card;
    }
    public GameObject card;
    //public cards deck;
    public void DrawCard()
    {
        GameObject handler = GameObject.Find("Handler");
        handle_switch switch_pl = handler.GetComponent<handle_switch>();
        if (switch_pl.getplay()) return;
        end_turn turn = handler.GetComponent<end_turn>();
        if (!turn.isPlayerTurn()) return;
        int value = Draw();

        for (int i = 0; i < 10; i++)
        {
            string temp = "card-" + i;
            card = GameObject.Find(temp);
            move scp = card.GetComponent<move>();
            if (i == value)
                scp.moves();
            else
            {
                scp.movesaway();
            }
        }
        play_draw = true;
    }
    public int getCurr() { return current; }
    public void setCurr(int value) { current = value; }
    public bool getplay() { return play_draw; }
    public void setplay() { play_draw = false; }
}
