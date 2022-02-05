using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Generator : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    

    [SerializeField]
    private float generator_x = 0;

    [SerializeField]
    private float generator_y = 0;

    [SerializeField]
    private float generator_z = 0;

    [SerializeField]
    private float delay = 0.08f;

    [SerializeField]
    private float delta_separation = 1.05f;


    void Start()
    {
        generator_x = transform.position.x;
        generator_y = transform.position.y;
        generator_z = transform.position.z;

        

        StartCoroutine(waiter());
    }


    IEnumerator waiter()
    {
        yield return new WaitForSeconds(delay);

        GameObject go = Instantiate(Object1, new Vector3(generator_x - delta_separation, generator_y, generator_z), Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("CubeGenerator").transform;

        go = Instantiate(Object2, new Vector3(generator_x, generator_y, generator_z), Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("CubeGenerator").transform;

        go = Instantiate(Object3, new Vector3(generator_x + delta_separation, generator_y, generator_z), Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("CubeGenerator").transform;

        yield return new WaitForSeconds(7*delay);

        


        StartCoroutine(waiter());
    }
    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(waiter());
    }
}
