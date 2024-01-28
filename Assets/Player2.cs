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
    public Animator anim;
    public Animator[] animArray;
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        anim = animArray[id];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;



        float x = Input.GetAxis("EjeX");
        float z = Input.GetAxis("EjeZ");
        if (x > 0)
        {
            direccion = d;
            direccionBala = transform.right;
            pos.x += speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        else if (x < 0)
        {
            direccion = a;
            direccionBala = -transform.right;
            pos.x -= speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        if (z > 0)
        {
            direccion = w;
            direccionBala = transform.forward;
            pos.z += speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        else if (z < 0)
        {
            direccion = w;
            direccionBala = transform.forward;
            direccion = s;
            direccionBala = -transform.forward;
            pos.z -= speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        if (x == 0 && z == 0)
        {
            anim.SetTrigger("Idle");

        }


        /*
        if (Input.GetKey("w"))
        {
            direccion = w;
            direccionBala = transform.forward;
            pos.z += speed * Time.deltaTime;
            anim.SetTrigger("Move");

        }
        else if (Input.GetKeyUp("w"))
        {
            
            anim.SetTrigger("Idle");

        }
        if (Input.GetKey("s"))
        {
            direccion = s;
            direccionBala = -transform.forward;
            pos.z -= speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        else if (Input.GetKeyUp("s"))
        {

            anim.SetTrigger("Idle");

        }
        if (Input.GetKey("d"))
        {
            direccion = d;
            direccionBala = transform.right;
            pos.x += speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        else if (Input.GetKeyUp("d"))
        {

            anim.SetTrigger("Idle");

        }
        if (Input.GetKey("a"))
        {

            direccion = a;
            direccionBala = -transform.right;
            pos.x -= speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        else if (Input.GetKeyUp("a"))
        {

            anim.SetTrigger("Idle");

        }


        */

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
                anim.SetTrigger("A1");
                StartCoroutine(disparo());
            }
            



            
        }
        if (Input.GetKey(KeyCode.X))
        {
            this.gameObject.GetComponent<jugador>().caramelos();
            GameManager.Instance.useAbility(1, "X", 3);
            anim.SetTrigger("A2");
        }
        if (Input.GetKey(KeyCode.C))
        {
            this.gameObject.GetComponent<jugador>().empujon();
            GameManager.Instance.useAbility(2, "C", 3);
            anim.SetTrigger("A3");
        }
        if (Input.GetKey(KeyCode.V))
        {
            GameManager.Instance.useAbility(3, "V", 3);
            anim.SetTrigger("A4");
        }

        

        IEnumerator disparo()
        {
            puedoDisparo = false;
            yield return new WaitForSeconds(0.3f);
            puedoDisparo = true;
        }

    }
}
