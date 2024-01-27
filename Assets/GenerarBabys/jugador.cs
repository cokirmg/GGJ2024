using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class jugador : MonoBehaviour
{
    public int vida = 100;
    public GameObject muerte;
    public GameObject[] enemigos;
    public int esteGM;
    string enemigo;
    // Start is called before the first frame update
    void Start()
    {
        if (esteGM == 1)
        {
            enemigo = "enemigo";
           
        }
        else if (esteGM == 2)
        {
            enemigo = "enemigo2";
            
        }
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

        enemigos = GameObject.FindGameObjectsWithTag(enemigo);

        for (int i = 0; i<enemigos.Length; i++)
        {
            enemigos[i].GetComponent<bebe>().speed = -enemigos[i].GetComponent<bebe>().speed;
        }

        yield return new WaitForSeconds(1.6f);

        for (int i = 0; i < enemigos.Length; i++)
        {
            enemigos[i].GetComponent<bebe>().speed = -enemigos[i].GetComponent<bebe>().speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == enemigo)
        {
            
            perderVida(collision.gameObject.GetComponent<bebe>().daño);
            Destroy(collision.gameObject);
        }
    }
}
