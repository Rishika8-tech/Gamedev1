using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollower : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform carTransform;
    public Transform cameraTransform;
  

    // Update is called once per frame
    void LateUpdate()
    {
        cameraTransform.position = new Vector3(carTransform.position.x, carTransform.position.y , - 10f);
    }
}
