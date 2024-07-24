using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public interface IInput
{
  public float Direction();

  public bool Jump();

  public bool Shoot();
}
