using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallCollision : MonoBehaviour
{    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "RedBall")
        {
            GameObject.Find("Score").GetComponent<Score>().score += 1;
            GameObject.Find("Score").GetComponent<Score>().ScoreUpdate();
            GameObject.Find("Drops").GetComponent<Drops>().drops += -1;
            GameObject.Find("Drops").GetComponent<Drops>().DropUpdate();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "BlueBall")
        {
            GameObject.Find("Score").GetComponent<Score>().score = 0;
            GameObject.Find("Score").GetComponent<Score>().ScoreUpdate();
            GameObject.Find("Drops").GetComponent<Drops>().drops = 10;
            GameObject.Find("Drops").GetComponent<Drops>().DropUpdate();

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
