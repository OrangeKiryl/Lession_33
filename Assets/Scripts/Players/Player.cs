using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent (typeof(NetworkTransform))]

public class Player : NetworkBehaviour
{
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
  private Rigidbody2D rigidbody2D;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
  [SerializeField] private float speed;
  [SerializeField] private float jumpPower;

  [SerializeField] private NetworkVariable<float> inputDirection = new(0, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
  [SerializeField] private NetworkVariable<bool> inputJump = new(false, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

  private void Awake()
  {
    rigidbody2D = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    if (IsOwner)
    {
      inputDirection.Value = 0;
      inputJump.Value = false;
    }
  }
}