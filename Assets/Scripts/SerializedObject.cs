using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[Serializable]
public class SerializedObject
{
    [SerializeField]
    private int a = 1;
    [SerializeField]
    private float b = 2f;

    //public SerializedObject()
    //{
    //    A = 1;
    //    B = 2;
    //}

    //public int A { get; set; }

    //public int B { get; set; }
}