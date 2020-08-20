using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCheck : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D other)
       {
          if (other.gameObject.tag == "Player")
             Time.timeScale = 0;
       }
}
