using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow_Spawner : MonoBehaviour
{
    public GameObject cow;
    private GameObject cowObject;

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

    public void createCow(){
        int location = PickRandomNumber();

        if(location == 0){
            cowObject = Instantiate(cow, new Vector3(8.5f, 2.5f, 6.3f), Quaternion.Euler(0.0f,-97.219f, 0f));
        }
        else if(location == 1){
            cowObject = Instantiate(cow, new Vector3(6.4f, 2.5f, 6.3f), Quaternion.Euler(0.0f,-97.219f, 0f));
        }
        else{
            cowObject = Instantiate(cow, new Vector3(7.4f, 2.5f, 5.5f), Quaternion.Euler(0.0f,-97.219f, 0f));
        }
    }
}
