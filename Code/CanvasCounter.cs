using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasCounter : MonoBehaviour
{
    TenSeconds TimerScript;
    TextMeshProUGUI timerText;

    public float Score = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        TimerScript = FindObjectOfType<TenSeconds>();
        timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        Score += TimerScript.increaseFactorScoreScript * Time.deltaTime;
        timerText.text = "Score: " + Score.ToString("F2"); // display with 2 decimal places
    }
}