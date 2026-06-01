using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto1 : MonoBehaviour
{
   public int contador=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col){ 
    
        if(col.gameObject.CompareTag("objeto")){ 
            contador++;
        Debug.Log("hubo colision con un pickable");
        Destroy(col.gameObject);}}

}
