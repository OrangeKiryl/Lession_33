using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
  [SerializeField] private NetworkButtons networkButtons;
  [SerializeField] private NetworkManager networkManager;

  private void Start()
  {
    networkButtons.request.AddListener(mode =>
    {
      switch (mode)
      {
        case NetworkButton.Mode.Host:
          networkManager.StartHost();
          break;
        case NetworkButton.Mode.Client:
          networkManager.StartClient();
          break;
      }
      networkButtons.Hide();
    });
  }
}
