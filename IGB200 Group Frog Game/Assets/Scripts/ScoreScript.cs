using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public TextMeshProUGUI Score;
    public int ScoreVal = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + ScoreVal;
    }
}
