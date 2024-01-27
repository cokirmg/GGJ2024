using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerCharacter : MonoBehaviour
{
    public GameObject character1, character2;
    public bool cd = false;
    public bool cd2 = false;
    public Image[] arrows;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Character1", character1.GetComponent<CharacterSelect>().index);
        PlayerPrefs.SetInt("Character2", character2.GetComponent<CharacterSelect>().index);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (cd2)
            {

            }
            else
            {
                StartCoroutine(Change1Character2());
            }
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (cd2)
            {

            }
            else
            {
                StartCoroutine(Change1Character());
            }
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (cd)
            {

            }
            else
            {
                StartCoroutine(ChangeCharacter());
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (cd)
            {

            }
            else
            {
                StartCoroutine(ChangeCharacter2());
            }
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (x > 0)
        {
            if (cd)
            {

            }
            else
            {
                StartCoroutine(ChangeCharacter());
            }
            
        }
        else if (x < 0)
        {
            if (cd)
            {

            }
            else
            {
                StartCoroutine(ChangeCharacter2());
            }
            
        }

    }



    IEnumerator Change1Character()
    {
        cd2 = true;
        arrows[1].GetComponent<Image>().color = Color.red;
        character1.GetComponent<CharacterSelect>().NextCharacter1();
        PlayerPrefs.SetInt("Character1", character1.GetComponent<CharacterSelect>().index);
        yield return new WaitForSeconds(0.5f);
        arrows[1].GetComponent<Image>().color = Color.white;
        cd2 = false;
    }
    IEnumerator Change1Character2()
    {
        cd2 = true;
        arrows[0].GetComponent<Image>().color = Color.red;
        character1.GetComponent<CharacterSelect>().PreviousCharacter1();
        PlayerPrefs.SetInt("Character1", character1.GetComponent<CharacterSelect>().index);
        yield return new WaitForSeconds(0.5f);
        arrows[0].GetComponent<Image>().color = Color.white;
        cd2 = false;
    }

    IEnumerator ChangeCharacter()
    {
        cd = true;
        arrows[3].GetComponent<Image>().color = Color.red;
        character2.GetComponent<CharacterSelect>().NextCharacter1();
        PlayerPrefs.SetInt("Character2", character1.GetComponent<CharacterSelect>().index);
        yield return new WaitForSeconds(0.5f);
        arrows[3].GetComponent<Image>().color = Color.white;
        cd = false;
    }
    IEnumerator ChangeCharacter2()
    {
        cd = true;
        arrows[2].GetComponent<Image>().color = Color.red;
        character2.GetComponent<CharacterSelect>().PreviousCharacter1();
        PlayerPrefs.SetInt("Character2", character1.GetComponent<CharacterSelect>().index);
        yield return new WaitForSeconds(0.5f);
        arrows[2].GetComponent<Image>().color = Color.white;
        cd = false;
    }
}
