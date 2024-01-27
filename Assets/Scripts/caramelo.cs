using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caramelo : MonoBehaviour
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
        if(collision.gameObject.tag == "enemigo" || collision.gameObject.tag == "enemigo1")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

}
