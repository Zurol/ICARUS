using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    float instance_x;
    float instance_y;
    float instance_z;

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {

        instance_x = transform.position.x;
        instance_y = transform.position.y;
        instance_z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        instance_z -= (float) speed * Time.deltaTime;
            if(instance_z <= 0){
                Destroy(gameObject);
            }else {
                transform.position = new Vector3(instance_x, instance_y, instance_z);
            }
        
    }
}
