using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal 
{
    private int id;
    protected string name;
    public string sound;
    
    public string GetName(){
        return name;
    }

    public void PlaySound(){
        Debug.Log(name + " : " + sound);
    }
}
