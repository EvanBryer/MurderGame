using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test");
        rend = GetComponent<Renderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("here");
        rend.enabled = false;
    }
    private void OnTriggerExit(Collider other){
        Debug.Log("Exit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
