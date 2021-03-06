using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballClocking : MonoBehaviour
{
    public bool hasGlass;

    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasGlass)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            this.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);

        if (other.transform.tag == "Player")
        {
            Debug.Log("불덩이에게 공격당한다");
            other.gameObject.GetComponent<CHAR_CharacterStatus>().HP -= 10;
            Destroy(gameObject);
        }
    }
}
