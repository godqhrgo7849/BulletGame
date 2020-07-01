using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public Cat(string _name){
        this.name = _name;
        this.sound = "냐옹";
    }

    public void Go(){
        Debug.Log("살금 살금~");
    }
}
