using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaccion_area : MonoBehaviour
{
    public int contador=0;
    public UIManager UIManagers;
    public bool sigue_en_juego_win;
    public GameObject pantalla_win;
    public bool sigue_en_juego_lose;
    public GameObject pantalla_lose;
    public GameObject[] objeto;
    void Awake()
    {
        UIManagers= FindObjectOfType<UIManager>();
        sigue_en_juego_lose=true;
        pantalla_lose.SetActive(false);
        sigue_en_juego_win=true;
        pantalla_win.SetActive(false);
        objeto = GameObject.FindGameObjectsWithTag("objeto");
    }

    // Update is called once per frame
    void Update()
    {
        if (sigue_en_juego_lose==false){
        pantalla_lose.SetActive(true);
        }
        if (sigue_en_juego_win==false){
        pantalla_win.SetActive(true);
        }
    }
    void OnTriggerEnter (Collider other){ 
        if (sigue_en_juego_lose == true){
        pantalla_lose.SetActive(false);
        if(other.gameObject.CompareTag("objeto")){ 
  
       other.gameObject.SetActive(false);
             UIManagers.addpointandupdatedcoreUI();
    }}}

}
