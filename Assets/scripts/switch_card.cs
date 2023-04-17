using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_card : MonoBehaviour
{
    private bool isListening = false;
    private GameObject selectedObject1;
    private GameObject selectedObject2;
    // Start is called before the first frame update
    void Start()
    {
        isListening = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    public void start_switch()
    {
        Debug.Log("start listening");
        if (isListening && Input.GetMouseButtonDown(0))
        {
            // Get the clicked object
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

                // Check if object is already selected
                if (selectedObject1 == null)
                {
                    selectedObject1 = clickedObject;
                    Debug.Log("Selected object 1: " + selectedObject1.name);
                }
                else if (selectedObject2 == null && clickedObject != selectedObject1)
                {
                    selectedObject2 = clickedObject;
                    Debug.Log("Selected object 2: " + selectedObject2.name);

                    // Both objects are selected, stop listening
                    isListening = false;

                    // Do something with the selected objects
                    Debug.Log("Selected objects: " + selectedObject1.name + " and " + selectedObject2.name);
                }
            }
            
        }
        Debug.Log("end listening");

    }
}
