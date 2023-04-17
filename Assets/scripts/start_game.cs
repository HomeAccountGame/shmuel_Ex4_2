using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_game : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject deck;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    private bool object2Started = false;

    void Update()
    {
        if (object2Started && !player1.activeSelf)
        {
            // start object1 after object2 has started
            player1.SetActive(true);
            player2.SetActive(true);
            player3.SetActive(true);
            player4.SetActive(true);
        }
    }

    public void Object2Started()
    {
        // set the flag to true when object2 has started
        object2Started = true;
    }
}
