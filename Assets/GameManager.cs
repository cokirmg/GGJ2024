using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public Image[] uiImage;
    // Start is called before the first frame update



    public static GameManager Instance
    {
        get
        {
            if(_instance is null)
            {
                Debug.Log("GameManager is null");
                
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void useAbility(int id, string key, int cooldown)
    {
        StartCoroutine(abilitiesCooldown(id, key, cooldown));

    }


    IEnumerator abilitiesCooldown(int id, string key, int cooldown)
    {

        uiImage[id].GetComponent<Image>().color = Color.black;
        for(int i=cooldown; i>0; i--)
        {
            uiImage[id].GetComponentInChildren<Text>().text = i.ToString();
            uiImage[id].GetComponentInChildren<Text>().color = Color.white;
            yield return new WaitForSeconds(1);
        }
        yield return new WaitForSeconds(0.1f);
        uiImage[id].GetComponent<Image>().color = Color.white;
        uiImage[id].GetComponentInChildren<Text>().text = "";
        

    }
    
}
