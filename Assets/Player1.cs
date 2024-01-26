using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
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
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (x > 0)
        {
            pos.x += speed * Time.deltaTime;
        }
        else if(x<0)
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (z > 0)
        {
            pos.z += speed * Time.deltaTime;
        }
        else if (z < 0)
        {
            pos.z -= speed * Time.deltaTime;
        }


        

        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= speed * Time.deltaTime;
        }
        transform.position = pos;

        if (Input.GetKey(KeyCode.H))
        {
            GameManager.Instance.useAbility(4, "H", 3);
        }
        if (Input.GetKey(KeyCode.J))
        {
            GameManager.Instance.useAbility(5, "J", 3);
        }
        if (Input.GetKey(KeyCode.K))
        {
            GameManager.Instance.useAbility(6, "K", 3);
        }
        if (Input.GetKey(KeyCode.L))
        {
            GameManager.Instance.useAbility(7, "L", 3);
        }

    }
}
