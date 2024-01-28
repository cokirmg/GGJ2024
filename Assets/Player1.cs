using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed = 2f;

    public GameObject balaPrefab;
    public float balaVelocidad;
    public Vector3 direccionBala;

    public bool puedoDisparo = true;
    public int id;
    public Animator anim;
    public Animator[] animArray;
    public GameObject w;
    public GameObject a;
    public GameObject s;
    public GameObject d;
    public GameObject direccion;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = animArray[id];
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
            anim.SetTrigger("Move");
        }
        else if(x<0)
        {
            pos.x -= speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        if (z > 0)
        {
            pos.z += speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        else if (z < 0)
        {
            pos.z -= speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }


        

        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direccion = a;
            direccionBala = -transform.right;
            pos.x += speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direccion = d;
            direccionBala = transform.right;
            pos.x -= speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direccion = w;
            direccionBala = transform.forward;
            pos.z += speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direccion = s;
            direccionBala = -transform.forward;
            pos.z -= speed * Time.deltaTime;
            anim.SetTrigger("Move");
        }
        transform.position = pos;

        if (Input.GetKey(KeyCode.H))
        {

            GameManager.Instance.useAbility(4, "H", 3);
        }
        if (Input.GetKey(KeyCode.J))
        {

            this.gameObject.GetComponent<jugador>().empujon();
            GameManager.Instance.useAbility(5, "J", 3);
        }
        if (Input.GetKey(KeyCode.K))
        {
            this.gameObject.GetComponent<jugador>().caramelos();
            GameManager.Instance.useAbility(6, "K", 3);
        }
        if (Input.GetKey(KeyCode.L))
        {
            if (puedoDisparo)
            {
                GameObject balaTemporal = Instantiate(balaPrefab, direccion.transform.position, Quaternion.identity) as GameObject;

                Rigidbody rb = balaTemporal.GetComponent<Rigidbody>();

                rb.AddForce(direccionBala * balaVelocidad);

                Destroy(balaTemporal, 3f);
                GameManager.Instance.useAbility(7, "L", 1);
                StartCoroutine(disparo());
            }
            

        }

    }

    IEnumerator disparo()
    {
        puedoDisparo = false;
        yield return new WaitForSeconds(0.3f);
        puedoDisparo = true;
    }

}
