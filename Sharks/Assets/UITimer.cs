using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UITimer : MonoBehaviour
{

    private float timer = 0.0f;
    private Text theText;
    private Component comp;

    // Use this for initialization
    void Start()
    {
        comp = this.gameObject.GetComponent("Text");
        theText = comp.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        theText.text = "Time: " + timer.ToString("F2");
    }
}