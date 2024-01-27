using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public int vida = 100;
    public GameObject muerte;
    public GameObject[] enemigos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)) 
        {
            StartCoroutine(empujeBebe());

        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            

        }
    }
    
    public void perderVida(int cantidad)
    {
        vida = vida - cantidad;
        if (vida <= 0)
        {
            muerte.SetActive(true);
            Destroy(this.gameObject);
            
        }
    }

    IEnumerator empujeBebe()
    {
        enemigos = GameObject.FindGameObjectsWithTag("enemigo");
        for(int i = 0; i<enemigos.Length; i++)
        {
            enemigos[i].GetComponent<bebe>().speed = -enemigos[i].GetComponent<bebe>().speed;
        }

        yield return new WaitForSeconds(1.6f);

        for (int i = 0; i < enemigos.Length; i++)
        {
            enemigos[i].GetComponent<bebe>().speed = -enemigos[i].GetComponent<bebe>().speed;
        }
    }
}
