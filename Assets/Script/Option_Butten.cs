using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_Butten : MonoBehaviour
{
    public GameObject OptionButten;

    public void OnButten()
    {
        OptionButten.SetActive(true);
    }
   public void OffButten()
    {
        OptionButten.SetActive(false);
    }
}
