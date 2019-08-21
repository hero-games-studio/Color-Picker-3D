using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotation : MonoBehaviour
{    
    private Touch touch;
    private Vector3 touchPosition;
    private Quaternion rotationZ;
    private float rotateSpeedModifier = 200.0f; 
    
   
    void Update()  
    {
        if (Input.GetMouseButton(0))
        {            
            rotationZ = Quaternion.Euler(0f, 0f, rotateSpeedModifier * Time.deltaTime);
            transform.rotation = rotationZ * transform.rotation;            
        }
        if (Input.GetMouseButton(1))
        {
            rotationZ = Quaternion.Euler(0f, 0f, -rotateSpeedModifier * Time.deltaTime);
            transform.rotation = rotationZ * transform.rotation;
        }
    } 
}

/*  Mobil'de denemek için kullanırız ilerde ve o zaman rotatespeed'i düşürmeyi unutma
  if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                rotationZ = Quaternion.Euler(0f, 0f, -touch.deltaPosition.x * rotateSpeedModifier);
                transform.rotation = rotationZ * transform.rotation;
            }
        }
     */
