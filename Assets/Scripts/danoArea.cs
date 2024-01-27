using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danoArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "enemigo" || collision.gameObject.tag == "enemigo1")
        {
            Debug.Log("entra al trigerin");
            collision.gameObject.GetComponent<bebe>().perderVida(2);
        }
    }
    
}
