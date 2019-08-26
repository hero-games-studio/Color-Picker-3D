using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;   

    public void ScoreUpdate()
    {        
        GetComponent<TextMesh>().text = score.ToString();
        if (score == 10)
        {
            GameObject.Find("NextLevel").GetComponent<MeshRenderer>().enabled = true;
            Time.timeScale = 0;
        }
    }
}
