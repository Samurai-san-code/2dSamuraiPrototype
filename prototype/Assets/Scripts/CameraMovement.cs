using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    Transform mytransform;
    public Vector3 direction;

    // Use this for initialization
    void Start()
    {
        
        mytransform = GetComponent<Transform>();
        direction = new Vector3(0, 0.1f , 0);
    }

    void Update()
    {
        if (Time.timeScale != 0)
        mytransform.position += direction;
        else
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene("SampleScene");
            
        }

    }
}