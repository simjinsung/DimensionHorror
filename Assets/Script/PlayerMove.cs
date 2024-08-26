using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movePower = 1f;

    private void Update()
    {
        
        float xMove = Input.GetAxis("Horizontal") * movePower * Time.deltaTime;
        float yMove = Input.GetAxis("Vertical") * movePower/2 * Time.deltaTime;
        this.transform.Translate(new Vector3 (xMove, yMove , 0));
    }
}
