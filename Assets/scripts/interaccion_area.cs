using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaccion_area : MonoBehaviour
{
    public int contador=0;
    public UIManager UIManagers;
    public bool sigue_en_juego;
    public GameObject pantalla_lose;
    void Awake()
    {
        UIManagers= FindObjectOfType<UIManager>();
        sigue_en_juego= true;
        pantalla_lose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (sigue_en_juego==false){
        pantalla_lose.SetActive(true);
        }
    }
    void OnTriggerEnter (Collider other){ 
        if (sigue_en_juego == true){
        pantalla_lose.SetActive(false);
        if(other.gameObject.CompareTag("objeto")){ 
        contador++;
        Debug.Log("hubo colision con un pickable");
        Debug.Log(contador);
        UIManagers.addpointandupdatedcoreUI();
        Destroy(other.gameObject);
    }}}

}
