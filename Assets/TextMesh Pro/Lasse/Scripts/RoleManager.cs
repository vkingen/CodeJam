using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleManager : MonoBehaviour
{
    public static RoleManager instance;

    [HideInInspector]
    public int role; // This variable is in charge of controlling what role the player is. The role can be either 1,2,3 or 4. 
    

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void ChooseRole(int roleNum)
    {
        role = roleNum;
    }
}
