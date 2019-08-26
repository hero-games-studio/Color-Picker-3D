using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBallCollision : MonoBehaviour
{   
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "BlueBall")
        {
            GameObject.Find("Canvas/Text").GetComponent<Score>().score += 1;
            GameObject.Find("Canvas/Text").GetComponent<Score>().ScoreUpdate();           
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "RedBall")
        {
            GameObject.Find("Canvas/Text").GetComponent<Score>().score = 0;
            GameObject.Find("Canvas/Text").GetComponent<Score>().ScoreUpdate();           
            GameObject[] blueBalls = GameObject.FindGameObjectsWithTag("BlueBall");
            GameObject[] redBalls = GameObject.FindGameObjectsWithTag("RedBall");
            for (int i = 0; i < blueBalls.Length; i++)
            {
                Destroy(blueBalls[i]);
            }
            for (int i = 0; i < redBalls.Length; i++)
            {
                Destroy(redBalls[i]);
            }
            Destroy(col.gameObject);
        }
    }
    
        
}
