using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class bebe : MonoBehaviour
{
    public float speed = 1f;
    public GameObject target;

    public GameObject esteGM;
    public int queGM;
    public int vida;
    public int daño = 20;
    // Start is called before the first frame update
    void Start()
    {
        if(queGM == 1)
        {
            esteGM = GameObject.Find("Game Manager1");
        }
        else if(queGM == 2)
        {
            esteGM = GameObject.Find("Game Manager2");
        }
        //esteGM = ;
        irAJugador();
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }
    
    
    public void perderVida(int dano)
    {
        vida = vida - dano;
        if(vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void irAJugador()
    {
        target = esteGM.GetComponent<generarbabyboom>().player;
    }
}
