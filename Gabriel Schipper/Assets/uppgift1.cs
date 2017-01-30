using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
    public int a = 1;
    public int b = 2;
    private int c = 0;
    private int d = 0;
	// Use this for initialization
	void Start () 
    {
        a = c;
        b = d;
        b = c;
        a = d;

	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
} 
