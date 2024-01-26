using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public int vida = 100;
    public GameObject muerte;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void perderVida(int cantidad)
    {
        vida = vida -cantidad;
        if (vida <= 0)
        {
            muerte.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
