using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scene_script : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        
    }
    void Update()
    {
        text.text = "yours preveus score is " + remove_coin.score.ToString();
    }
}
