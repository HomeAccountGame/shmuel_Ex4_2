using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class textField : MonoBehaviour
{

    public void Setstring(string str)
    {
        GetComponent<TextMeshPro>().text = str;
    }
}
