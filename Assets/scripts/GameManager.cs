using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float timer=60;
       void Update()
    {
    timer -= Time.deltaTime;
    }


   
}
