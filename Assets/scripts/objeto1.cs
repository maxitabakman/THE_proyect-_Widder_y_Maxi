using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col){ 
    
        if(col.gameObject.CompareTag("objeto")){ 
        Debug.Log("hubo colision con un pickable");
        Destroy(col.gameObject);}}

}
