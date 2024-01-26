using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class generarbabyboom : MonoBehaviour
{
    public GameObject bebeGO;
    public GameObject[] waypoints;
    public int numWaypoint;

    public GameObject player;

    
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(generarEnemigos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator generarEnemigos()
    {
        numWaypoint = Random.Range(0, waypoints.Length);
        Instantiate(bebeGO, waypoints[numWaypoint].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(0.5f, 3f));
        StartCoroutine(generarEnemigos());
    }
}
