using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LightControll : MonoBehaviour
{
    [HideInInspector]
    public GameObject Object;

    [HideInInspector]
    private int count = 0;

    public GameObject[] Colors;

    public Material MatRojo;
    public Material MatAzul;
    public Material MatAmarillo;

    public Material originalRed;
    public Material originalBlue;
    public Material originalYellow;

    [SerializeField]
    private float delay = 1.0f;

    [HideInInspector]
    public GameObject[] Cubes;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(delay);


        print(count);

        var temporal = GameObject.FindGameObjectsWithTag("RedCube");

        if (count % 3 == 0)
        {
            temporal = GameObject.FindGameObjectsWithTag("RedCube");
            print("///" + temporal.Length);

            if (temporal.Length > 0)
            {
                foreach (GameObject cube in temporal)
                {
                    cube.GetComponent<MeshRenderer>().material = MatRojo;
                }
            }

            temporal = GameObject.FindGameObjectsWithTag("BlueCube");
            print("\\\\" + temporal.Length);

            if (temporal.Length > 0)
            {
                foreach (GameObject cube in temporal)
                {
                    cube.GetComponent<MeshRenderer>().material = originalBlue;
                }
            }

            temporal = GameObject.FindGameObjectsWithTag("YellowCube");
            print("\\\\" + temporal.Length);

            if (temporal.Length > 0)
            {
                foreach (GameObject cube in temporal)
                {
                    cube.GetComponent<MeshRenderer>().material = originalYellow;
                }
            }
        }
        else if (count % 3 == 1)
        {
            temporal = GameObject.FindGameObjectsWithTag("BlueCube");
            print("\\\\" + temporal.Length);

            if (temporal.Length > 0)
            {
                foreach (GameObject cube in temporal)
                {
                    cube.GetComponent<MeshRenderer>().material = MatAzul;
                }
            }

            temporal = GameObject.FindGameObjectsWithTag("RedCube");
            print("\\\\" + temporal.Length);

            if (temporal.Length > 0)
            {
                foreach (GameObject cube in temporal)
                {
                    cube.GetComponent<MeshRenderer>().material = originalRed;
                }
            }

            temporal = GameObject.FindGameObjectsWithTag("YellowCube");
            print("\\\\" + temporal.Length);

            if (temporal.Length > 0)
            {
                foreach (GameObject cube in temporal)
                {
                    cube.GetComponent<MeshRenderer>().material = originalYellow;
                }
            }
        }
        else if (count % 3 == 2)
        {
            temporal = GameObject.FindGameObjectsWithTag("YellowCube");
            print("\\\\" + temporal.Length);

            if (temporal.Length > 0)
            {
                foreach (GameObject cube in temporal)
                {
                    cube.GetComponent<MeshRenderer>().material = MatAmarillo;
                }
            }

            temporal = GameObject.FindGameObjectsWithTag("RedCube");
            print("\\\\" + temporal.Length);

            if (temporal.Length > 0)
            {
                foreach (GameObject cube in temporal)
                {
                    cube.GetComponent<MeshRenderer>().material = originalRed;
                }
            }

            temporal = GameObject.FindGameObjectsWithTag("BlueCube");
            print("\\\\" + temporal.Length);

            if (temporal.Length > 0)
            {
                foreach (GameObject cube in temporal)
                {
                    cube.GetComponent<MeshRenderer>().material = originalBlue;
                }
            }
        }

        count++;

        StartCoroutine(waiter());
    }


    // Update is called once per frame
    void Update()
    {
        
        
    }
}
