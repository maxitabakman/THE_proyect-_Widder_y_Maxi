using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public interaccion_area interaccion_areas;
    public float timer=1;
    
       void awake (){
     interaccion_areas= FindObjectOfType<interaccion_area>();
       }
       void Update()
    {
    timer -= Time.deltaTime;
    if (timer < 0){
        Time.timeScale = 0f;
        interaccion_areas.sigue_en_juego = false;
    }
    }
    public void restart(){
        timer=1;
    }
}
