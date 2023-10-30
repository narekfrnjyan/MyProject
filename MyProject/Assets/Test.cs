using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Runtime.InteropServices;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Dll.Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

internal static class Dll
{
    [DllImport("ConsoleApplication2.dll")]
    internal static extern int Load();
}