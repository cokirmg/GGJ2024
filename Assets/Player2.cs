using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;


        if (Input.GetKey(KeyCode.Z))
        {
            GameManager.Instance.useAbility(0, "Z", 3);
        }
        if (Input.GetKey(KeyCode.X))
        {
            GameManager.Instance.useAbility(1, "X", 3);
        }
        if (Input.GetKey(KeyCode.C))
        {
            GameManager.Instance.useAbility(2, "C", 3);
        }
        if (Input.GetKey(KeyCode.V))
        {
            GameManager.Instance.useAbility(3, "V", 3);
        }

        

    }
}
