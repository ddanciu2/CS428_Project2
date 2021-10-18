using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien_Spawner : MonoBehaviour
{
    public GameObject alien;
    private GameObject alienObject;

    private int PickRandomNumber(){
        int randomNum = Random.Range(0,3);
        return randomNum;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void createAlien(){
        int location = PickRandomNumber();

        if(location == 0){
            alienObject = Instantiate(alien, new Vector3(7f, 2.6f, -0.8f), Quaternion.Euler(0.0f,-270.219f, 0f));
        }
        else if(location == 1){
            alienObject = Instantiate(alien, new Vector3(7f, 2.6f, 1.2f), Quaternion.Euler(0.0f,-270.219f, 0f));
        }
        else{
        }
    }
}
