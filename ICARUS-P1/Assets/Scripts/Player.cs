using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    enum row { Left, Center, Right };
    row m_row = row.Center;

    [SerializeField]
    private float delta_movement = 1.25f;

    [SerializeField]
    private float delay = 4.0f;

    public bool useGravity = false;

    [HideInInspector] 
    new public Rigidbody rigidbody;

    Vector3 current_position;

	private void Awake()
	{
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = true;
    }

	// Start is called before the first frame update
	void Start()
    {
        
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(delay);
        rigidbody.useGravity = true;

    }


	// Update is called once per frame
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            if (m_row == row.Center) {
                m_row = row.Left;
            } else if (m_row == row.Right) {
                m_row = row.Center;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (m_row == row.Center)
            {
                m_row = row.Right;
            }
            else if (m_row == row.Left)
            {
                m_row = row.Center;
            }
        }

        if (m_row == row.Left) {
            current_position = transform.position;

            current_position.x = Mathf.Lerp(current_position.x, -delta_movement, Time.deltaTime * 5);
        } else if (m_row == row.Right)
        {
            current_position = transform.position;

            current_position.x = Mathf.Lerp(current_position.x, delta_movement, Time.deltaTime * 5);
        } else if (m_row == row.Center)
        {
            current_position = transform.position;

            current_position.x = Mathf.Lerp(current_position.x, 0, Time.deltaTime * 5);
        }

        transform.position = current_position;


    }
}
