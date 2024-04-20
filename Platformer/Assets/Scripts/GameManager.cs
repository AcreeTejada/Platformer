using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;         //static variable that will hold singleton

    //Called when script instance is being loaded
    void Awake()
    {
        //Make a singleton to prevent more than one instance of an object
        if (instance == null)                   //if instance hasn't been set
        {
            DontDestroyOnLoad(gameObject);      //Dont destroy object when loading new scene
            instance = this;                    //set instance to this object
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
