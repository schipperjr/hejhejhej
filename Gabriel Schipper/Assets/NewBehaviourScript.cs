using UnityEngine;
using System.Collections;
// I give the ints a value
public class uppgift1 : MonoBehaviour 
{
    public int a = 1;
    public int b = 2;
    private int c = 0;
    private int d = 0;
	// int a = int c. int b = int d. int b = int c. int a = int d.
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
