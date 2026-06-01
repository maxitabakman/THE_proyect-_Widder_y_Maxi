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
    void OnTriggerEnter (Collider other){ 
    
        if(other.gameObject.CompareTag("objeto")){ 
            contador++;
        Debug.Log("hubo colision con un pickable");
         Debug.Log(contador);
        Destroy(other.gameObject);}}

}
