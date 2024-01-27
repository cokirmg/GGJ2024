using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{

    public int index = 0;
    public GameObject[] characters;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextCharacter1()
    {
        characters[index].SetActive(false);
        if (index == characters.Length-1)
        {
            index = 0;
        }
        else
        {
            index++;
        }
        characters[index].SetActive(true);
    }
    public void PreviousCharacter1()
    {
        characters[index].SetActive(false);
        if (index == 0)
        {
            index = characters.Length-1;
        }
        else
        {
            index--;
        }
        characters[index].SetActive(true);
    }

    public void NextCharacter2()
    {
        characters[index].SetActive(false);
        if (index == characters.Length - 1)
        {
            index = 0;
        }
        else
        {
            index++;
        }
        characters[index].SetActive(true);
    }
    public void PreviousCharacter2()
    {
        characters[index].SetActive(false);
        if (index == 0)
        {
            index = characters.Length - 1;
        }
        else
        {
            index--;
        }
        characters[index].SetActive(true);
    }
}