using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public GameObject player;
  
    void Update()
    {
        Vector3 camera = player.transform.position - this.transform.position;
        Vector3 cameraMove = new Vector3(camera.x, camera.y, 0f);
        this.transform.Translate(cameraMove);
    }
}
