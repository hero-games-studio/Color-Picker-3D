using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public GameObject blueBall, redBall;
   // public float speed = 0.1f;          gravity scale ile toplar düşüyor bu yüzden speed'e gerek yok şimdilik.
    public float spawnRate;
    float nextSpawn = 0f;
    int whatToSpawn;
    
       
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 3);
            spawnRate = Random.Range(0.7f, 1.4f);

            switch (whatToSpawn)
            {
                case 1:
                  //  GameObject go = Instantiate(blueBall, transform.position, Quaternion.identity);    şu haliyle gereksiz burası ama ileride tekrar kullanabiliriz diye şimdilik bıraktım
                    GameObject go = Instantiate(blueBall, new Vector3(-4.2f, 8.3f, 0), Quaternion.identity);

                    // go.GetComponent<Rigidbody>().velocity = Vector3.down * speed * Time.deltaTime;   gravity scale ile toplar düşüyor bu yüzden speed'e gerek yok şimdilik.
                    break;
                case 2:
                    //  go = Instantiate(redBall, transform.position, Quaternion.identity);       şu haliyle gereksiz burası ama ileride tekrar kullanabiliriz diye şimdilik bıraktım
                    go = Instantiate(redBall, new Vector3(-4.2f, 8.3f, 0), Quaternion.identity);
                    // go.GetComponent<Rigidbody>().velocity = Vector3.down * speed * Time.deltaTime;   gravity scale ile toplar düşüyor bu yüzden speed'e gerek yok şimdilik.
                    break;
            }
            nextSpawn = Time.time + spawnRate;
        }
    }
}
