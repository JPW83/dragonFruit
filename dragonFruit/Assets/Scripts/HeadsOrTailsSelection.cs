using UnityEngine;
using System.Collections;

public class HeadsOrTailsSelection : MonoBehaviour
{
    public string HeadsOrTails;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void Heads()
    {
        HeadsOrTails = "Heads";
    }

    public void Tails()
    {
        HeadsOrTails = "Tails";
    }

    public void Edge()
    {
        HeadsOrTails = "Edge";
    }
}
