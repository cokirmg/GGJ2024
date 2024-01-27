using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaDano : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="enemigo"|| collision.gameObject.tag == "enemigo2")
        {
            collision.gameObject.GetComponent<bebe>().perderVida(1);
            Destroy(this.gameObject);
        }
    }
}
