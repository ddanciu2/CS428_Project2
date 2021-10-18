using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUGSPAWN_VENDINGMACHINE : MonoBehaviour
{
    public GameObject bug;
    private GameObject bugObject;

    private int PickRandomNumber(){
        int randomNum = Random.Range(0,2);
        return randomNum;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void createBug(){
        int location = PickRandomNumber();

        if(location == 0){
            bugObject = Instantiate(bug, new Vector3(4.5f, -1.7f, 5.9f), Quaternion.Euler(0.0f,-97.219f, 0f));
        }
        else{
            bugObject = Instantiate(bug, new Vector3(5.0f, -1.7f, 5.9f), Quaternion.Euler(0.0f,-97.219f, 0f));
        }
    }
}
