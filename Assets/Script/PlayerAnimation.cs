using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            anime.SetTrigger("RightMove");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anime.SetTrigger("LeftMove");
        }
        if(Input.GetKeyUp(KeyCode.D))
            {
            anime.SetTrigger("RightStop");
            }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anime.SetTrigger("LeftStop");
        }
    }
}
