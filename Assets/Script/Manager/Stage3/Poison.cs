using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{
    private float timer = 0;
    public float time = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= time)
        {
            Stage3Manager.instance.is_poison = true;

            timer = 0;
        }
        else
        {
            Stage3Manager.instance.is_poison = false;
        }
    }
}
