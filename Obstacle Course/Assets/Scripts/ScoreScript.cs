using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    Text text;
    float theTime;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        theTime += Time.deltaTime * speed;
        string minutes = Mathf.Floor((theTime % 3600) / 59).ToString("00");
        string seconds = (theTime % 59).ToString("00");
        text.text = "Time: " + minutes + ":" + seconds;
    }
}
