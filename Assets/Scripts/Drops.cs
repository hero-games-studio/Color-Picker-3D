using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drops : MonoBehaviour
{
    public int drops = 10;

    public void DropUpdate()
    {
        GetComponent<TextMesh>().text = drops.ToString();
    }
}
