using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCharacter : MonoBehaviour
{
    public GameObject character1, character2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            character1.GetComponent<CharacterSelect>().NextCharacter1();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            character1.GetComponent<CharacterSelect>().PreviousCharacter1();
        }
        
    }
}
