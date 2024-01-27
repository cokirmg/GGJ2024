using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 2f;

    public GameObject balaPrefab;
    public float balaVelocidad;
    public Vector3 direccionBala;

    public bool puedoDisparo = true;

    public GameObject w;
    public GameObject a;
    public GameObject s;
    public GameObject d;
    public GameObject direccion;
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
            direccion = w;
            direccionBala = transform.forward;
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            direccion = s;
            direccionBala = -transform.forward;
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            direccion = d;
            direccionBala = transform.right;
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {

            direccion = a;
            direccionBala = -transform.right;
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;


        if (Input.GetKey(KeyCode.Z))
        {
            if (puedoDisparo)
            {
                GameObject balaTemporal = Instantiate(balaPrefab, direccion.transform.position, Quaternion.identity) as GameObject;

                Rigidbody rb = balaTemporal.GetComponent<Rigidbody>();

                rb.AddForce(direccionBala * balaVelocidad);

                Destroy(balaTemporal, 3f);
                GameManager.Instance.useAbility(0, "Z", 1);
                StartCoroutine(disparo());
            }
            



            
        }
        if (Input.GetKey(KeyCode.X))
        {
            this.gameObject.GetComponent<jugador>().caramelos();
            GameManager.Instance.useAbility(1, "X", 3);
        }
        if (Input.GetKey(KeyCode.C))
        {
            this.gameObject.GetComponent<jugador>().empujon();
            GameManager.Instance.useAbility(2, "C", 3);
        }
        if (Input.GetKey(KeyCode.V))
        {
            GameManager.Instance.useAbility(3, "V", 3);
        }

        

        IEnumerator disparo()
        {
            puedoDisparo = false;
            yield return new WaitForSeconds(0.3f);
            puedoDisparo = true;
        }

    }
}
