using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text Mesh Pro 

[RequireComponent(typeof(TMP_Text))] // Ensures a TextMeshPro Text component is attached
public class NewBehaviourScript : MonoBehaviour
{
    [Header("Timer Settings")]
    [Tooltip("one will increase by one every second, .5 is 50% speed,  etc.")]
    public float speed = 1.0f;

    [Tooltip("a string to show to the right of the number")]
    public string label;

    TMP_Text textUI; //TMP_Text is short for TextMeshPro Text Component
    float timeCurrent;

    // Start is called before the first frame update
    void Start()
    {
        textUI = GetComponent<TMP_Text>();
        textUI.text = "Starting ...";
        timeCurrent = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeCurrent += Time.deltaTime * speed;
        textUI.text = label + " " + timeCurrent.ToString("N2");
    }
}
